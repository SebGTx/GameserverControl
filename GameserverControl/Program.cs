using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GameserverControl
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GCApplicationContext());
        }
    }

    public class GCApplicationContext : ApplicationContext
    {
        private delegate void EnableDisableToolStripMenuItemDelegate(string gameGUID, string menuName, bool enabled);

        private NotifyIcon trayIcon;
        private ToolStripMenuItem GamesToolStripMenuItem;

        private string GCProgramDataFolder;
        private string GCXMLConfigFile;
        private XmlDocument GCXMLConfig = new XmlDocument();
        private XmlNode ConfigsXMLNode;
        private XmlNode WebServerXMLNode;
        private XmlNode GamesXMLNode;

        private Dictionary<string, Process> GameProcess;

        private HttpListener listener;
        private string url;
        
        // *********************************************************
        // Start
        public GCApplicationContext()
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            Console.WriteLine(version);

            // Initialize GameProcess dictionnary
            GameProcess = new Dictionary<string, Process> { };

            // Initialize Tray Icon
            trayIcon = new NotifyIcon()
            {
                Icon = Properties.Resources.AppIcon,
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true
            };
            GamesToolStripMenuItem = new ToolStripMenuItem("Games", Properties.Resources.controller);
            GamesToolStripMenuItem.Name = "games";
            GamesToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("New", Properties.Resources.controller_add, new EventHandler(MenuGameNewEdit_Click)));
            trayIcon.ContextMenuStrip.Items.Add(GamesToolStripMenuItem);
            trayIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            trayIcon.ContextMenuStrip.Items.Add(new ToolStripMenuItem("About", Properties.Resources.information, new EventHandler(MenuAbout_Click)));
            trayIcon.ContextMenuStrip.Items.Add(new ToolStripSeparator());
            trayIcon.ContextMenuStrip.Items.Add(new ToolStripMenuItem("Exit", Properties.Resources.door_in, new EventHandler(MenuExit_Click)));

            // Initialize GCProgramDataFolder
            GCProgramDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\GameserverControl";
            if (!Directory.Exists(GCProgramDataFolder))
            {
                Directory.CreateDirectory(GCProgramDataFolder);
            }

            // Get XML Config or create it
            GCXMLConfigFile = GCProgramDataFolder + "\\GCConfig.xml";
            if (!File.Exists(GCXMLConfigFile))
            {
                ConfigsXMLNode = GCXMLConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Configs", null));
                WebServerXMLNode = ConfigsXMLNode.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "WebServer", null));
                GamesXMLNode = ConfigsXMLNode.AppendChild( GCXMLConfig.CreateNode(XmlNodeType.Element, "Games", null) );
            }
            else
            {
                GCXMLConfig.Load(GCXMLConfigFile);
                // Root Node
                ConfigsXMLNode = GCXMLConfig.SelectSingleNode("/Configs");
                if (ConfigsXMLNode == null)
                {
                    GCXMLConfig = new XmlDocument();
                    ConfigsXMLNode = GCXMLConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Configs", null));
                }
                // WebServer Node
                WebServerXMLNode = ConfigsXMLNode.SelectSingleNode("./WebServer");
                if (WebServerXMLNode == null)
                    WebServerXMLNode = ConfigsXMLNode.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "WebServer", null));
                WebServerXMLNode = XMLCreateOrUpdateWebServerConfig(WebServerXMLNode);
                // Games Node
                GamesXMLNode = ConfigsXMLNode.SelectSingleNode("./Games");
                if (GamesXMLNode == null)
                    GamesXMLNode = ConfigsXMLNode.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Games", null));
            }

            // Read Games Config
            if (GamesXMLNode.HasChildNodes)
            {
                GamesToolStripMenuItem.DropDownItems.Add(new ToolStripSeparator());
                XmlNode newGameConfig;
                foreach (XmlNode GameXMLNode in GamesXMLNode.ChildNodes)
                {
                    string gameGUID = GameXMLNode.Attributes["guid"].Value;
                    newGameConfig = XMLCreateOrUpdateGameConfig(GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']"));
                    XMLAddGame(newGameConfig);
                }
            }

            // Create a Http server and start listening for incoming connections
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            try
            {
                listener.Start();
                Console.WriteLine("Listening for connections on {0}", url);
                // Handle requests
                Task listenTask = HTTPHandleIncomingConnections();
            }
            catch (HttpListenerException e)
            {
                MessageBox.Show("Unable to listen on port " + WebServerXMLNode.SelectSingleNode("./Port").InnerText + "\rYou can't control GameserverControl from another computer\r\rTry to correct this with GCSetComputerSettings and restart GameserverControl\r\rError message :\r" + e.Message, "Can't start webserver on specified port", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // *********************************************************
        // XML functions
        public void XMLSaveConfig()
        {
            // Write XML Config
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("  ");
            settings.CloseOutput = true;
            settings.OmitXmlDeclaration = false;
            settings.Encoding = Encoding.UTF8;
            XmlWriter writer = XmlWriter.Create(GCXMLConfigFile, settings);
            GCXMLConfig.WriteTo(writer);
            writer.Flush();
            writer.Close();
        }

        private XmlNode XMLCreateOrUpdateWebServerConfig(XmlNode WebServerConfig)
        {
            XmlNode tmpNode;
            tmpNode = WebServerConfig.SelectSingleNode("./Port");
            if (tmpNode == null)
            {
                tmpNode = WebServerConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Port", null));
                tmpNode.InnerText = "8008";
            }
            url = "http://+:" + tmpNode.InnerText + "/";
            return WebServerConfig;
        }

        public void XMLAddGame(XmlNode GameConfig)
        {
            string gameGUID = GameConfig.Attributes["guid"].Value;
            if (GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']") == null)
            {
                GamesXMLNode.AppendChild(GameConfig);
            }
            string GameName = GameConfig.SelectSingleNode("./Name").InnerText;
            ToolStripMenuItem GameMenuToolStripItem = new ToolStripMenuItem(GameName, Properties.Resources.RedLightImg);
            GameMenuToolStripItem.Name = gameGUID;
            GameMenuToolStripItem.Tag = gameGUID;
            // Start
            ToolStripMenuItem start = new ToolStripMenuItem("Start", Properties.Resources.GreenLightImg, new EventHandler(MenuGameStart_Click));
            start.Name = "start";
            GameMenuToolStripItem.DropDownItems.Add(start);
            ToolStripMenuItem stop = new ToolStripMenuItem("Stop", Properties.Resources.RedLightImg, new EventHandler(MenuGameStop_Click));
            // Stop
            stop.Name = "stop";
            stop.Enabled = false;
            GameMenuToolStripItem.DropDownItems.Add(stop);
            // Separator
            GameMenuToolStripItem.DropDownItems.Add(new ToolStripSeparator());
            // Edit
            ToolStripMenuItem edit = new ToolStripMenuItem("Edit", Properties.Resources.application_edit, new EventHandler(MenuGameNewEdit_Click));
            edit.Name = "edit";
            GameMenuToolStripItem.DropDownItems.Add(edit);
            // Remove
            ToolStripMenuItem remove = new ToolStripMenuItem("Remove", Properties.Resources.controller_delete, new EventHandler(MenuGameRemove_Click));
            remove.Name = "remove";
            GameMenuToolStripItem.DropDownItems.Add(remove);
            // Add new game menu to Games
            GamesToolStripMenuItem.DropDownItems.Add(GameMenuToolStripItem);
        }

        private XmlNode XMLCreateOrUpdateGameConfig()
        {
            return XMLCreateOrUpdateGameConfig(null);
        }

        private XmlNode XMLCreateOrUpdateGameConfig(XmlNode GameConfig)
        {
            XmlNode newGameConfig;
            XmlNode GamesXMLNode = GCXMLConfig.SelectSingleNode("/Games");
            if (GameConfig != null)
            {
                newGameConfig = GameConfig;
            }
            else
            {
                newGameConfig = GCXMLConfig.CreateNode(XmlNodeType.Element, "Game", null);
            }
            if (newGameConfig.Attributes["guid"] == null) { newGameConfig.Attributes.Append(GCXMLConfig.CreateAttribute("guid")); }
            if (newGameConfig.SelectSingleNode("./Name") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Name", null)); }
            if (newGameConfig.SelectSingleNode("./Program") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Program", null)); }
            if (newGameConfig.SelectSingleNode("./Args") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Args", null)); }
            if (newGameConfig.SelectSingleNode("./WorkingDir") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "WorkingDir", null)); }
            if (newGameConfig.SelectSingleNode("./Logs") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Logs", null)); }
            if (newGameConfig.SelectSingleNode("./Backup") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Backup", null)); }
            if (newGameConfig.SelectSingleNode("./BackupDir") == null) { newGameConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "BackupDir", null)); }
            return newGameConfig;
        }

        // *********************************************************
        // Tray Icon Menu functions
        private void MenuGameStart_Click(object sender, EventArgs e)
        {
            string gameGUID;
            XmlNode GameXMLNode;


            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)sender;
            if (senderToolStripMenuItem.OwnerItem.Tag != null)
            {
                gameGUID = senderToolStripMenuItem.OwnerItem.Tag.ToString();
                GameXMLNode = GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']");
                string[] ctrlReturn = ProcessCtrlBeforeStart(GameXMLNode);
                if (ctrlReturn !=null)
                {
                    MessageBox.Show(ctrlReturn[0], ctrlReturn[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Process process = ProcessStart(GameXMLNode);
                GameProcess.Add(gameGUID, process);
            }
        }

        private void MenuGameStop_Click(object sender, EventArgs e)
        {
            string gameGUID;
            XmlNode GameXMLNode;

            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)sender;
            if (senderToolStripMenuItem.OwnerItem.Tag != null)
            {
                gameGUID = senderToolStripMenuItem.OwnerItem.Tag.ToString();
                GameXMLNode = GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']");
                string[] ctrlReturn = ProcessCtrlBeforeStop(GameXMLNode);
                if (ctrlReturn != null)
                {
                    MessageBox.Show(ctrlReturn[0], ctrlReturn[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                ProcessStop(GameXMLNode);
            }
        }

        private void MenuGameNewEdit_Click(object sender, EventArgs e)
        {
            string gameGUID;
            XmlNode GameXMLNode;

            frmGameConfig GameConfigForm = new frmGameConfig();
            GameConfigForm.GCAC = this;
            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)sender;
            if (senderToolStripMenuItem.OwnerItem.Tag == null)
            {
                GameConfigForm.newGame = true;
                gameGUID = Guid.NewGuid().ToString();
                GameXMLNode = XMLCreateOrUpdateGameConfig();
            }
            else
            {
                GameConfigForm.newGame = false;
                gameGUID = senderToolStripMenuItem.OwnerItem.Tag.ToString();
                GameXMLNode = XMLCreateOrUpdateGameConfig( GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']") );
                GameConfigForm.Controls["tlpGlobal"].Controls["txtName"].Text = GameXMLNode.SelectSingleNode("./Name").InnerText;
                GameConfigForm.Controls["tlpGlobal"].Controls["tlpProgram"].Controls["txtProgram"].Text = GameXMLNode.SelectSingleNode("./Program").InnerText;
                GameConfigForm.Controls["tlpGlobal"].Controls["txtArgs"].Text = GameXMLNode.SelectSingleNode("./Args").InnerText;
                GameConfigForm.Controls["tlpGlobal"].Controls["tlpWorkingDir"].Controls["txtWorkingDir"].Text = GameXMLNode.SelectSingleNode("./WorkingDir").InnerText;
                GameConfigForm.Controls["tlpGlobal"].Controls["tlpLogs"].Controls["txtLogs"].Text = GameXMLNode.SelectSingleNode("./Logs").InnerText;
                if (GameXMLNode.SelectSingleNode("./Backup").HasChildNodes)
                {
                    foreach (XmlNode childNode in GameXMLNode.SelectSingleNode("./Backup").ChildNodes)
                    {
                        GameConfigForm.addBackupPath(childNode.InnerText);
                    }
                }
                GameConfigForm.Controls["tlpGlobal"].Controls["tlpBackupDir"].Controls["txtBackupDir"].Text = GameXMLNode.SelectSingleNode("./BackupDir").InnerText;
            }

            GameConfigForm.GamesConfig = GCXMLConfig;
            GameConfigForm.newGameConfig = GameXMLNode;
            GameConfigForm.Controls["tlpGlobal"].Controls["txtGUID"].Text = gameGUID;
            GameConfigForm.ShowDialog();
        }

        private void MenuGameRemove_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)sender;
            if (senderToolStripMenuItem.OwnerItem.Tag != null)
            {
                DialogResult result = MessageBox.Show("Do you want to remove \"" + senderToolStripMenuItem.OwnerItem.Text + "\" ?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string gameGUID = senderToolStripMenuItem.OwnerItem.Tag.ToString();
                    XmlNode GameXMLNode = XMLCreateOrUpdateGameConfig(GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']"));
                    GamesXMLNode.RemoveChild(GameXMLNode);
                    senderToolStripMenuItem.OwnerItem.Dispose();
                }
            }
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            AboutBox GameConfigForm = new AboutBox();
            GameConfigForm.ShowDialog();
        }
         
        private void MenuExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close Gameserver Control ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                // Stop all started game
                if (GameProcess != null)
                {
                    foreach (KeyValuePair<string, Process> entry in GameProcess)
                    {
                        // do something with entry.Value or entry.Key
                        Process process = entry.Value;
                        process.EnableRaisingEvents = false;
                        process.Exited -= ProcessExited;
                        process.CloseMainWindow();
                        try
                        {
                            for (int i = 1; i < 10; i++)
                            {
                                System.Threading.Thread.Sleep(1000);
                                if (process.HasExited) break;
                            }
                            if (!process.HasExited) { process.Kill(); }
                        }
                        catch { }
                    }
                }

                // Close HTTP listener
                listener.Close();

                // Write XML Config
                XMLSaveConfig();

                // Exit Application
                Application.Exit();
            }
        }

        // *********************************************************
        // Process functions
        private void ProcessEnableDisableToolStripMenuItem(string gameGUID, string menuName, bool enabled)
        {
            if (trayIcon.ContextMenuStrip.InvokeRequired)
            {
                var d = new EnableDisableToolStripMenuItemDelegate(ProcessEnableDisableToolStripMenuItem);
                trayIcon.ContextMenuStrip.Invoke(d, new object[] { gameGUID, menuName, enabled });
            }
            else
            {
                ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)GamesToolStripMenuItem.DropDownItems[gameGUID];
                senderToolStripMenuItem.DropDownItems[menuName].Enabled = enabled;
            }
        }

        private string[] ProcessCtrlBeforeStart(XmlNode GameXMLNode)
        {
            if (GameXMLNode == null)
            {
                string[] result = { "This game does not exist", "Game not found" };
                return result;
            }

            string gameGUID = GameXMLNode.Attributes["guid"].Value;
            if (GameProcess.ContainsKey(gameGUID))
            {
                string[] result = { "This game is already started", "Already started" };
                return result;
            }

            if (!File.Exists(GameXMLNode.SelectSingleNode("./Program").InnerText))
            {
                string[] result = { "The program specified was not found", "Program not found" };
                return result;
            }

            return null;
        }

        private Process ProcessStart(XmlNode GameXMLNode)
        {
            string gameGUID = GameXMLNode.Attributes["guid"].Value;
            string programToStart = GameXMLNode.SelectSingleNode("./Program").InnerText;

            // Systray menu management
            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)GamesToolStripMenuItem.DropDownItems[gameGUID];
            senderToolStripMenuItem.Image = Properties.Resources.YellowLightImg;
            ProcessEnableDisableToolStripMenuItem(gameGUID, "start", false);
            ProcessEnableDisableToolStripMenuItem(gameGUID, "edit", false);
            ProcessEnableDisableToolStripMenuItem(gameGUID, "remove", false);

            // Process start
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.EnvironmentVariables.Add("GameGUID", gameGUID);
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.UseShellExecute = false;
            startInfo.FileName = programToStart;
            if (Directory.Exists(GameXMLNode.SelectSingleNode("./WorkingDir").InnerText))
            {
                startInfo.WorkingDirectory = GameXMLNode.SelectSingleNode("./WorkingDir").InnerText;
            }
            if (GameXMLNode.SelectSingleNode("./Args").InnerText.Length > 0)
            {
                startInfo.Arguments = GameXMLNode.SelectSingleNode("./Args").InnerText;
            }

            Process process = new Process();
            process.StartInfo = startInfo;
            process.EnableRaisingEvents = true;
            process.Exited += new EventHandler(ProcessExited);
            process.Start();

            // Systray menu management
            senderToolStripMenuItem.Image = Properties.Resources.GreenLightImg;
            ProcessEnableDisableToolStripMenuItem(gameGUID, "stop", true);

            return process;
        }

        private string[] ProcessCtrlBeforeStop(XmlNode GameXMLNode)
        {

            if (GameXMLNode == null)
            {
                string[] result = { "This game does not exist", "Game not found" };
                return result;
            }

            string gameGUID = GameXMLNode.Attributes["guid"].Value;
            if (!GameProcess.ContainsKey(gameGUID))
            {
                string[] result = { "This game is not started", "Not started" };
                return result;
            }

            return null;
        }

        private void ProcessStop(XmlNode GameXMLNode)
        {
            string gameGUID = GameXMLNode.Attributes["guid"].Value;
            if (!GameProcess.ContainsKey(gameGUID)) { return; }

            Process process = GameProcess[gameGUID];
            process.CloseMainWindow();
            try
            {
                for (int i = 1; i < 10; i++)
                {
                    System.Threading.Thread.Sleep(1000);
                    if (process.HasExited) break;
                }
                if (!process.HasExited) { process.Kill(); }
            }
            catch { }
        }

        private void ProcessExited(object sender, System.EventArgs e)
        {
            // Process information
            Process process = (Process)sender;
            ProcessStartInfo startInfo = (ProcessStartInfo)process.StartInfo;
            string gameGUID = startInfo.EnvironmentVariables["GameGUID"];
            Console.WriteLine(
                $"GameGUID     : {gameGUID}\n" +
                $"Exit time    : {process.ExitTime}\n" +
                $"Exit code    : {process.ExitCode}\n" +
                $"Elapsed time : {Math.Round((process.ExitTime - process.StartTime).TotalMilliseconds)}"
            );

            // Systray menu management
            ToolStripMenuItem senderToolStripMenuItem = (ToolStripMenuItem)GamesToolStripMenuItem.DropDownItems[gameGUID];
            senderToolStripMenuItem.Image = Properties.Resources.YellowLightImg;
            ProcessEnableDisableToolStripMenuItem(gameGUID, "stop", false);

            // Stop Process
            process.Close();
            GameProcess.Remove(gameGUID);

            // Backup
            XmlNode GameXMLNode = GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']");
            string backupDir = GameXMLNode.SelectSingleNode("BackupDir").InnerText;
            XmlNode GameBackup = GameXMLNode.SelectSingleNode("Backup");
            if ((backupDir.Trim().Length > 0) && (GameBackup.HasChildNodes))
            {
                if (!Directory.Exists(backupDir)) { Directory.CreateDirectory(backupDir); }
                string backupPath = backupDir + "\\" + GameXMLNode.SelectSingleNode("Name").InnerText + "_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".zip";
                List<string> filesToBackup = new List<string>();
                foreach (XmlNode childNode in GameXMLNode.SelectSingleNode("./Backup").ChildNodes)
                {
                    if (File.Exists(childNode.InnerText))
                    {
                        filesToBackup.Add(childNode.InnerText);
                    }
                    else if (Directory.Exists(childNode.InnerText))
                    {
                        filesToBackup.AddRange(Directory.GetFiles(childNode.InnerText, "*.*", SearchOption.AllDirectories));
                    }

                }
                using (FileStream zipToOpen = new FileStream(backupPath, FileMode.OpenOrCreate))
                {
                    using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                    {
                        foreach(string file in filesToBackup)
                        {
                            archive.CreateEntryFromFile(file, file.Substring(3));
                        }
                    }
                }
            }
            // Systray menu management
            senderToolStripMenuItem.Image = Properties.Resources.RedLightImg;
            ProcessEnableDisableToolStripMenuItem(gameGUID, "start", true);
            ProcessEnableDisableToolStripMenuItem(gameGUID, "edit", true);
            ProcessEnableDisableToolStripMenuItem(gameGUID, "remove", true);
        }

        // *********************************************************
        // HTTP functions
        private async Task HTTPHandleIncomingConnections()
        {
            // While a user hasn't visited the `shutdown` url, keep on handling requests
            while (true)
            {
                // Will wait here until we hear from a connection
                HttpListenerContext ctx = await listener.GetContextAsync();

                // Peel out the requests and response objects
                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                // Print out some info about the request
                Console.WriteLine(req.Url.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine();

                string[] result = { "text/html", "<!DOCTYPE><html><head><title>Gameserver Control</title></head><body></body></html>" };
                if ((req.HttpMethod == "GET") && (req.Url.AbsolutePath == "/config")) { result = HTTPResultConfig(); }
                if ((req.HttpMethod == "GET") && (req.Url.AbsolutePath == "/start")) { result = HTTPResultStart(req.QueryString["guid"]); }
                if ((req.HttpMethod == "GET") && (req.Url.AbsolutePath == "/stop")) { result = HTTPResultStop(req.QueryString["guid"]); }

                // Write the response info
                byte[] data = Encoding.UTF8.GetBytes(String.Format(result[1]));
                resp.ContentType = result[0];
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                // Write out to the response stream (asynchronously), then close it
                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }

        private string[] HTTPResultConfig()
        {
            string[] result = { "application/xml", GCXMLConfig.OuterXml };
            return result;
        }

        private string[] HTTPResultStart(string gameGUID)
        {
            XmlNode GameXMLNode;
            XmlDocument XMLResult = new XmlDocument();
            XmlNode XMLResultNode = XMLResult.AppendChild(XMLResult.CreateNode(XmlNodeType.Element, "Result", null));
            XmlNode tmpNode;

            if (gameGUID == null)
            {
                tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                tmpNode.InnerText = "Error";
                XMLResultNode.AppendChild(tmpNode);
                tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "Error", null);
                tmpNode.InnerText = "GUID Not defined";
                XMLResultNode.AppendChild(tmpNode);
            }
            else
            {
                GameXMLNode = GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']");

                string[] ctrlReturn = ProcessCtrlBeforeStart(GameXMLNode);
                if (ctrlReturn != null)
                {
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                    tmpNode.InnerText = ctrlReturn[1];
                    XMLResultNode.AppendChild(tmpNode);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "Error", null);
                    tmpNode.InnerText = ctrlReturn[0];
                    XMLResultNode.AppendChild(tmpNode);
                } 
                else
                {
                    Process process = ProcessStart(GameXMLNode);
                    GameProcess.Add(gameGUID, process);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                    tmpNode.InnerText = "Starting";
                    XMLResultNode.AppendChild(tmpNode);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "GUID", null);
                    tmpNode.InnerText = gameGUID;
                    XMLResultNode.AppendChild(tmpNode);
                }
            }

            string[] result = { "application/xml", XMLResult.OuterXml };
            return result;
        }

        private string[] HTTPResultStop(string gameGUID)
        {
            XmlNode GameXMLNode;
            XmlDocument XMLResult = new XmlDocument();
            XmlNode XMLResultNode = XMLResult.AppendChild(XMLResult.CreateNode(XmlNodeType.Element, "Result", null));
            XmlNode tmpNode;

            if (gameGUID == null)
            {
                tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                tmpNode.InnerText = "Error";
                XMLResultNode.AppendChild(tmpNode);
                tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "Error", null);
                tmpNode.InnerText = "GUID Not defined";
                XMLResultNode.AppendChild(tmpNode);
            }
            else
            {
                GameXMLNode = GamesXMLNode.SelectSingleNode("./Game[@guid='" + gameGUID + "']");

                string[] ctrlReturn = ProcessCtrlBeforeStop(GameXMLNode);
                if (ctrlReturn != null)
                {
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                    tmpNode.InnerText = ctrlReturn[1];
                    XMLResultNode.AppendChild(tmpNode);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "Error", null);
                    tmpNode.InnerText = ctrlReturn[0];
                    XMLResultNode.AppendChild(tmpNode);
                }
                else
                {
                    ProcessStop(GameXMLNode);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "State", null);
                    tmpNode.InnerText = "Stopping";
                    XMLResultNode.AppendChild(tmpNode);
                    tmpNode = XMLResult.CreateNode(XmlNodeType.Element, "GUID", null);
                    tmpNode.InnerText = gameGUID;
                    XMLResultNode.AppendChild(tmpNode);
                }
            }

            string[] result = { "application/xml", XMLResult.OuterXml };
            return result;
        }
    }
}
