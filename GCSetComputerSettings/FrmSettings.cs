using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace GCSetComputerSettings
{
    public partial class FrmSettings : Form
    {
        private string GCProgramDataFolder;
        private string GCXMLConfigFile;
        private XmlDocument GCXMLConfig = new XmlDocument();
        private XmlNode ConfigsXMLNode;
        private XmlNode WebServerXMLNode;

        public FrmSettings()
        {
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
            }

            InitializeComponent();

            this.txtPort.Text = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            this.txtPort.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);

            this.txtLogin.Text = WebServerXMLNode.SelectSingleNode("./Login").InnerText;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);

            this.txtPassword.Text = WebServerXMLNode.SelectSingleNode("./Password").InnerText;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);
        }

        private void txtConfig_TextChanged(object sender, EventArgs e)
        {
            butSave.Enabled = true;
            butGetListenPort.Enabled = false;
            butAddFirewall.Enabled = false;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            WebServerXMLNode.SelectSingleNode("./Port").InnerText = this.txtPort.Text;
            XMLSaveConfig();
            butSave.Enabled = false;
            butGetListenPort.Enabled = true;
            butAddFirewall.Enabled = true;
        }

        private void butListenPort_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh http add urlacl url="http://+:8080/" user=%USERNAME%
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            string[] urls = { "http://+:" + port + "/"};
            foreach (string url in urls)
            {
                Console.WriteLine(url);
                CallNETSH("http add urlacl url=\"" + url + "\" user=\"" + userName + "\"");
            }
        }

        private void butRemoveListenPort_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh http delete urlacl url="http://+:8080/"
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            string[] urls = { "http://+:" + port + "/" };
            foreach (string url in urls)
            {
                Console.WriteLine(url);
                CallNETSH("http delete urlacl url=\"" + url + "\"");
            }
        }

        private void butFirewall_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh advfirewall firewall add rule name="GameserverControl" dir=in action=allow protocol=TCP localport=8080
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            CallNETSH("advfirewall firewall add rule name=\"GameserverControl\" dir=in action=allow protocol=TCP localport=" + port);
        }

        private void butRemoveFirewall_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh advfirewall firewall delete rule name="GameserverControl"
            CallNETSH("advfirewall firewall delete rule name=\"GameserverControl\"");
        }

        // *********************************************************
        // XML functions
        private void XMLSaveConfig()
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
            // Port Node
            tmpNode = WebServerConfig.SelectSingleNode("./Port");
            if (tmpNode == null)
            {
                tmpNode = WebServerConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Port", null));
                tmpNode.InnerText = "8008";
            }
            // Login Node
            tmpNode = WebServerConfig.SelectSingleNode("./Login");
            if (tmpNode == null)
            {
                tmpNode = WebServerConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Login", null));
                tmpNode.InnerText = "admin";
            }
            // Password Node
            tmpNode = WebServerConfig.SelectSingleNode("./Password");
            if (tmpNode == null)
            {
                tmpNode = WebServerConfig.AppendChild(GCXMLConfig.CreateNode(XmlNodeType.Element, "Password", null));
                tmpNode.InnerText = "admin";
            }
            return WebServerConfig;
        }

        // *********************************************************
        // NETSH functions
        private void CallNETSH(string args)
        {
            string netshCommand = $"chcp 65001 >nul && netsh {args}";

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + netshCommand,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8, // Lecture UTF-8
                StandardErrorEncoding = Encoding.UTF8,
            };

            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);
            if (!hasAdministrativeRight)
            {
                processInfo.Verb = "runas";
            }

            Process process = new Process
            {
                StartInfo = processInfo,
                EnableRaisingEvents = true
            };
            process.Exited += new EventHandler(ProcessExited);

            try
            {
                process.Start();
                process.WaitForExit();
            }
            catch (Win32Exception)
            {
                // This will be thrown if the user cancels the prompt
            }
       }

        private void ProcessExited(object sender, System.EventArgs e)
        {
            // Process information
            Process process = (Process)sender;
            ProcessStartInfo startInfo = (ProcessStartInfo)process.StartInfo;

            //string StdOutput = getCMDOutput(process.StandardOutput); //.ReadToEnd();
            //string StdError = getCMDOutput(process.StandardError); //.ReadToEnd();
            string StdOutput = process.StandardOutput.ReadToEnd();
            string StdError = process.StandardError.ReadToEnd();
            Console.WriteLine(
                $"Arguments    : {startInfo.Arguments}\n" +
                $"Exit time    : {process.ExitTime}\n" +
                $"Std Output   : {StdOutput}\n" +
                $"Exit code    : {process.ExitCode}\n" +
                $"Std Error    : {StdError}\n" +
                $"Elapsed time : {Math.Round((process.ExitTime - process.StartTime).TotalMilliseconds)}"
            );

            if (process.ExitCode > 0)
            {
                MessageBox.Show(StdOutput + StdError, "Error in NETSH command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine("Error in NETSH command : " + StdOutput + StdError);
            }
            else
            {
                MessageBox.Show(StdOutput, "NETSH command successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Debug.WriteLine("NETSH command successfull : " + StdOutput);
            }
        }
    }
}
