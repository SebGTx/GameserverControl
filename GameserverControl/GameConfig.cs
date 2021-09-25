using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace GameserverControl
{
    public partial class frmGameConfig : Form
    {
        public GCApplicationContext GCAC;
        public bool newGame;
        public XmlDocument GamesConfig;
        public XmlNode newGameConfig;

        public frmGameConfig()
        {
            InitializeComponent();
            this.ActiveControl = txtName;
        }

        private void toolTipBalloon(Control editControl, Control labelControl, string Error)
        {
            editControl.Focus();

            ToolTip newToolTip = new ToolTip();
            newToolTip.AutoPopDelay = 5000;
            newToolTip.InitialDelay = 1000;
            newToolTip.ReshowDelay = 500;
            newToolTip.ShowAlways = true;
            newToolTip.IsBalloon = true;
            newToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            newToolTip.ToolTipTitle = labelControl.Text + ":";
            newToolTip.SetToolTip(editControl, " ");
            newToolTip.Show(Error, editControl, editControl.Width / 10, editControl.Height, 5000);
        }

        private bool FieldControl()
        {
            if (txtName.Text.Trim().Length == 0) {
                toolTipBalloon(txtName, lblName, "Mandatory field");
                return false;
            }
            if (txtProgram.Text.Trim().Length == 0)
            {
                toolTipBalloon(txtProgram, lblProgram, "Mandatory field");
                return false;
            }
            return true;
        }

        private string ChooseFile(TextBox textControl, string strFilters)
        {
            string ActualFile = textControl.Text;
            string ActualFileDir = "";
            if (ActualFile.LastIndexOf("\\") > 0)
            {
                ActualFileDir = ActualFile.Substring(0, ActualFile.LastIndexOf("\\"));
            }
            if (Directory.Exists(ActualFileDir)) { openFileDialogCtrl.InitialDirectory = ActualFileDir;  }
            if (File.Exists(ActualFile)) {
                openFileDialogCtrl.FileName = ActualFile.Substring(ActualFile.LastIndexOf("\\") + 1);
            }
            else
            {
                openFileDialogCtrl.FileName = "";
            }
            openFileDialogCtrl.Filter = strFilters;
            if (openFileDialogCtrl.ShowDialog(this) == DialogResult.OK)
            {
                return openFileDialogCtrl.FileName;
            }
            else
            {
                return textControl.Text;
            }
        }
        private void butProgram_Click(object sender, EventArgs e)
        {
            txtProgram.Text = ChooseFile(txtProgram, "Program (*.exe;*.com;*.bat;*.cmd)|*.exe;*.com;*.bat;*.cmd|All files (*.*)|*.*");
        }

        private void butBeforeStart_Click(object sender, EventArgs e)
        {
            txtBeforeStart.Text = ChooseFile(txtBeforeStart, "Program (*.exe;*.com;*.bat;*.cmd)|*.exe;*.com;*.bat;*.cmd|All files (*.*)|*.*");
        }

        private void butWorkingDir_Click(object sender, EventArgs e)
        {
            string ActualWorkingDir = txtWorkingDir.Text;
            if (Directory.Exists(ActualWorkingDir))
            {
                folderBrowserDialogCtrl.SelectedPath = txtWorkingDir.Text;
            }
            else
            {
                string ActualProgram = txtProgram.Text;
                string ActualProgramDir = "";
                if (ActualProgram.LastIndexOf("\\") > 0)
                {
                    ActualProgramDir = ActualProgram.Substring(0, ActualProgram.LastIndexOf("\\"));
                }
                if (Directory.Exists(ActualProgramDir))
                {
                    folderBrowserDialogCtrl.SelectedPath = ActualProgramDir;
                }
                else
                {
                    folderBrowserDialogCtrl.SelectedPath = null;
                }
            }
            if (folderBrowserDialogCtrl.ShowDialog(this) == DialogResult.OK) {
                txtWorkingDir.Text = folderBrowserDialogCtrl.SelectedPath;
            }
        }

        private void butLogs_Click(object sender, EventArgs e)
        {
            txtLogs.Text = ChooseFile(txtLogs, "Log files (*.log)|*.log|Text files (*.txt)|*.log|All files (*.*)|*.*");
        }

        public void addBackupPath(string backupPath)
        {
            addBackupPath(backupPath, true);
        }

        private void addBackupPath(string backupPath, bool inXML)
        {
            if (!lstBackup.Items.Contains(backupPath))
            {
                lstBackup.Items.Add(backupPath);
            }
            if (!inXML)
            {
                XmlNode tmpNode = GamesConfig.CreateNode(XmlNodeType.Element, "Element", null);
                tmpNode.InnerText = backupPath;
                newGameConfig.SelectSingleNode("./Backup").AppendChild(tmpNode);
            }
        }

        private void butBackupAddFile_Click(object sender, EventArgs e)
        {
            openFileDialogCtrl.Filter = "All files (*.*)|*.*";
            if (openFileDialogCtrl.ShowDialog(this) == DialogResult.OK)
            {
                addBackupPath(openFileDialogCtrl.FileName, false);
            }
        }

        private void butBackupAddFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialogCtrl.SelectedPath = null;
            if (folderBrowserDialogCtrl.ShowDialog(this) == DialogResult.OK)
            {
                addBackupPath(folderBrowserDialogCtrl.SelectedPath, false);
            }
        }

        private void butBackupRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to remove selected backup ?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                while (lstBackup.SelectedIndex >= 0)
                {
                    XmlNode childNode;
                    while ((childNode = newGameConfig.SelectSingleNode("./Backup/Element[text() = '" + lstBackup.Items[lstBackup.SelectedIndex] + "']")) != null)
                    {
                        newGameConfig.SelectSingleNode("./Backup").RemoveChild(childNode);
                    }
                    lstBackup.Items.RemoveAt(lstBackup.SelectedIndex);
                }
            }
        }

        private void butBackupDir_Click(object sender, EventArgs e)
        {
            string ActualBackupDir = txtBackupDir.Text;
            if (Directory.Exists(ActualBackupDir))
            {
                folderBrowserDialogCtrl.SelectedPath = txtBackupDir.Text;
            }
            else
            {
                folderBrowserDialogCtrl.SelectedPath = null;
            }
            if (folderBrowserDialogCtrl.ShowDialog(this) == DialogResult.OK)
            {
                txtBackupDir.Text = folderBrowserDialogCtrl.SelectedPath;
            }
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            if (FieldControl())
            {
                newGameConfig.Attributes["guid"].Value = txtGUID.Text;
                newGameConfig.SelectSingleNode("./Name").InnerText = txtName.Text;
                newGameConfig.SelectSingleNode("./Program").InnerText = txtProgram.Text;
                newGameConfig.SelectSingleNode("./Args").InnerText = txtArgs.Text;
                newGameConfig.SelectSingleNode("./WorkingDir").InnerText = txtWorkingDir.Text;
                newGameConfig.SelectSingleNode("./BeforeStart").InnerText = txtBeforeStart.Text;
                newGameConfig.SelectSingleNode("./Logs").InnerText = txtLogs.Text;
                newGameConfig.SelectSingleNode("./BackupDir").InnerText = txtBackupDir.Text;
                if (newGame)
                {
                    GCAC.XMLAddGame(newGameConfig);
                }
                GCAC.XMLSaveConfig();
                this.Close();
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
