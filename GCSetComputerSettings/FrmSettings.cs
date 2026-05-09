using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

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

            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;

            bool ListeningPortRightsExist = UrlAclExists(GenNETSHurl(port));
            bool FirewallRulesExist = FirewallRulesExists("GameserverControl");
            bool StartupEnabled = IsStartupEnabled();

            this.txtPort.Text = port;
            this.txtPort.ReadOnly = ListeningPortRightsExist || FirewallRulesExist;
            this.txtPort.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);

            this.txtLogin.Text = WebServerXMLNode.SelectSingleNode("./Login").InnerText;
            this.txtLogin.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);

            this.txtPassword.Text = WebServerXMLNode.SelectSingleNode("./Password").InnerText;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtConfig_TextChanged);

            this.butAddRightsListenPort.Enabled = !ListeningPortRightsExist;
            this.butRemoveRightsListenPort.Enabled = ListeningPortRightsExist;

            this.butAddFirewall.Enabled = !FirewallRulesExist;
            this.butRemoveFirewall.Enabled = FirewallRulesExist;

            this.butEnableStartWithWindows.Enabled = !StartupEnabled;
            this.butDisableStartWithWindows.Enabled = StartupEnabled;
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox tb)
            {
                string port = tb.Text;
                System.Windows.Forms.Button[] buttons = { butAddRightsListenPort, butRemoveRightsListenPort, butAddFirewall, butRemoveFirewall };
                foreach (System.Windows.Forms.Button but in buttons)
                {
                    try
                    {
                        string format = but.Tag as string;
                        but.Text = string.Format(format, port);
                    }
                    catch { }
                }
            }
        }

        private void txtPort_ReadOnlyChanged(object sender, EventArgs e)
        {
            if (sender is System.Windows.Forms.TextBox tb)
            {
                if (tb.ReadOnly)
                {
                    tb.ForeColor = SystemColors.GrayText;
                    tb.Font = new Font(tb.Font, FontStyle.Italic);
                }
                else
                {
                    tb.ForeColor = SystemColors.WindowText;
                    tb.Font = new Font(tb.Font, FontStyle.Regular);
                }
            }
        }

        private void txtConfig_TextChanged(object sender, EventArgs e)
        {
            butSave.Enabled = true;
            butAddRightsListenPort.Enabled = false;
            butAddFirewall.Enabled = false;
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            WebServerXMLNode.SelectSingleNode("./Port").InnerText = this.txtPort.Text;
            XMLSaveConfig();
            butSave.Enabled = false;
            butAddRightsListenPort.Enabled = true;
            butAddFirewall.Enabled = true;
        }

        private void butListenPort_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh http add urlacl url="http://+:8080/" user=%USERNAME% #for actual user, can use group
            SecurityIdentifier groupSID = new System.Security.Principal.SecurityIdentifier("S-1-5-32-545");
            string groupName = groupSID.Translate(typeof(System.Security.Principal.NTAccount)).Value;
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            string url = GenNETSHurl(port);
            CallNETSH("http add urlacl", "url=\"" + url + "\" user=\"" + groupName + "\"");
        }

        private void butRemoveListenPort_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh http delete urlacl url="http://+:8080/"
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            string url = GenNETSHurl(port);
            CallNETSH("http delete urlacl", "url=\"" + url + "\"");
        }

        private void butAddFirewall_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh advfirewall firewall add rule name="GameserverControl" dir=in action=allow protocol=TCP localport=8080
            string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
            CallNETSH("advfirewall firewall add rule", "name=\"GameserverControl\" dir=in action=allow protocol=TCP localport=" + port);
        }

        private void butRemoveFirewall_Click(object sender, EventArgs e)
        {
            // Commandes NETSH :
            // netsh advfirewall firewall delete rule name="GameserverControl"
            CallNETSH("advfirewall firewall delete rule", "name=\"GameserverControl\"");
        }

        private void butEnableStartWithWindows_Click(object sender, EventArgs e)
        {
            EnableDisableStartup(true);
        }

        private void butDisableStartWithWindows_Click(object sender, EventArgs e)
        {
            EnableDisableStartup(false);
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
        // Registry functions

        static bool IsStartupEnabled()
        {
            RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rkApp.GetValue("GameserverControl") != null)
                return true;
            else
                return false;
        }

        void EnableDisableStartup(bool StartWithWindows)
        {
            RegistryKey rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (StartWithWindows)
            {
                rkApp.SetValue("GameserverControl", "\"" + Application.StartupPath + "GameserverControl.exe\"");
                butEnableStartWithWindows.Enabled = false;
                butDisableStartWithWindows.Enabled = true;
            }
            else
            {
                rkApp.DeleteValue("GameserverControl", false);
                butEnableStartWithWindows.Enabled = true;
                butDisableStartWithWindows.Enabled = false;
            }
        }

        // *********************************************************
        // NETSH functions

        static private string GenNETSHurl(string port)
        {
            return "http://+:" + port + "/";
        }

        static bool UrlAclExists(string url)
        {
            try
            {
                string netshCommand = $"chcp 65001 >nul && netsh http show urlacl";

                ProcessStartInfo psi = new ProcessStartInfo
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

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Case-insensitive search for the URL
                    return output.IndexOf(url, StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking URL ACL: " + ex.Message);
                return false;
            }
        }

        static bool FirewallRulesExists(string name)
        {
            try
            {
                string netshCommand = $"chcp 65001 >nul && netsh advfirewall firewall show rule name=\"{name}\"";

                ProcessStartInfo psi = new ProcessStartInfo
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

                using (Process process = Process.Start(psi))
                {
                    string output = process.StandardOutput.ReadToEnd();
                    process.WaitForExit();

                    // Case-insensitive search for the URL
                    return output.IndexOf(name, StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking FIREWALL RULES: " + ex.Message);
                return false;
            }
        }

        private void CallNETSH(string command, string args)
        {
            string netshCommand = $"chcp 65001 >nul && netsh {command} {args}";
            Debug.WriteLine(netshCommand);

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
                EnvironmentVariables =
                {
                    ["NETSH_COMMAND"] = command,
                    ["NETSH_ARGS"] = args
                }
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

        async private void ProcessExited(object sender, System.EventArgs e)
        {
            // Process information
            Process process = (Process)sender;
            ProcessStartInfo startInfo = (ProcessStartInfo)process.StartInfo;

            string StdOutput = process.StandardOutput.ReadToEnd();
            string StdError = process.StandardError.ReadToEnd();
            string NetSHCommand;
            try
            {
                NetSHCommand = startInfo.EnvironmentVariables["NETSH_COMMAND"];
            }
            catch
            {
                NetSHCommand = "";
            }

            Debug.WriteLine(
                $"Command      : {NetSHCommand}\n" +
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
                bool txtPortReadOnly;
                string port = WebServerXMLNode.SelectSingleNode("./Port").InnerText;
                switch (NetSHCommand)
                {
                    case "http add urlacl":
                        await butAddRightsListenPort.InvokeAsync(() => { butAddRightsListenPort.Enabled = false; });
                        await butRemoveRightsListenPort.InvokeAsync(() => { butRemoveRightsListenPort.Enabled = true; });
                        txtPortReadOnly = true;
                        await txtPort.InvokeAsync(() => { txtPort.ReadOnly = txtPortReadOnly; });
                        break;
                    case "http delete urlacl":
                        await butAddRightsListenPort.InvokeAsync(() => { butAddRightsListenPort.Enabled = true; });
                        await butRemoveRightsListenPort.InvokeAsync(() => { butRemoveRightsListenPort.Enabled = false; });
                        txtPortReadOnly = FirewallRulesExists("GameserverControl");
                        await txtPort.InvokeAsync(() => { txtPort.ReadOnly = txtPortReadOnly; });
                        break;
                    case "advfirewall firewall add rule":
                        await butAddFirewall.InvokeAsync(() => { butAddFirewall.Enabled = false; });
                        await butRemoveFirewall.InvokeAsync(() => { butRemoveFirewall.Enabled = true; });
                        txtPortReadOnly = true;
                        await txtPort.InvokeAsync(() => { txtPort.ReadOnly = txtPortReadOnly; });
                        break;
                    case "advfirewall firewall delete rule":
                        await butAddFirewall.InvokeAsync(() => { butAddFirewall.Enabled = true; });
                        await butRemoveFirewall.InvokeAsync(() => { butRemoveFirewall.Enabled = false; });
                        txtPortReadOnly = UrlAclExists(GenNETSHurl(port));
                        await txtPort.InvokeAsync(() => { txtPort.ReadOnly = txtPortReadOnly; });
                        break;
                }
            }
        }
    }
}
