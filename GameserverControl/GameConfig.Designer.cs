
namespace GameserverControl
{
    partial class frmGameConfig
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameConfig));
            lblGUID = new System.Windows.Forms.Label();
            txtGUID = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            tlpGlobal = new System.Windows.Forms.TableLayoutPanel();
            txtName = new System.Windows.Forms.TextBox();
            lblProgram = new System.Windows.Forms.Label();
            tlpProgram = new System.Windows.Forms.TableLayoutPanel();
            butProgram = new System.Windows.Forms.Button();
            txtProgram = new System.Windows.Forms.TextBox();
            lblArgs = new System.Windows.Forms.Label();
            txtArgs = new System.Windows.Forms.TextBox();
            lblWorkingDir = new System.Windows.Forms.Label();
            tlpWorkingDir = new System.Windows.Forms.TableLayoutPanel();
            butWorkingDir = new System.Windows.Forms.Button();
            txtWorkingDir = new System.Windows.Forms.TextBox();
            lblBeforeStart = new System.Windows.Forms.Label();
            tlpBeforeStart = new System.Windows.Forms.TableLayoutPanel();
            butBeforeStart = new System.Windows.Forms.Button();
            txtBeforeStart = new System.Windows.Forms.TextBox();
            lblLogs = new System.Windows.Forms.Label();
            tlpLogs = new System.Windows.Forms.TableLayoutPanel();
            txtLogs = new System.Windows.Forms.TextBox();
            butLogs = new System.Windows.Forms.Button();
            lblBackup = new System.Windows.Forms.Label();
            tlpBackup = new System.Windows.Forms.TableLayoutPanel();
            lstBackup = new System.Windows.Forms.ListBox();
            butBackupAddFile = new System.Windows.Forms.Button();
            butBackupAddFolder = new System.Windows.Forms.Button();
            butBackupRemove = new System.Windows.Forms.Button();
            lblBackupDir = new System.Windows.Forms.Label();
            tlpBackupDir = new System.Windows.Forms.TableLayoutPanel();
            butBackupDir = new System.Windows.Forms.Button();
            txtBackupDir = new System.Windows.Forms.TextBox();
            tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            butSave = new System.Windows.Forms.Button();
            butCancel = new System.Windows.Forms.Button();
            tlpCheckBox = new System.Windows.Forms.TableLayoutPanel();
            cbAutoStart = new System.Windows.Forms.CheckBox();
            cbAutoRestartOnCrash = new System.Windows.Forms.CheckBox();
            openFileDialogCtrl = new System.Windows.Forms.OpenFileDialog();
            folderBrowserDialogCtrl = new System.Windows.Forms.FolderBrowserDialog();
            tlpGlobal.SuspendLayout();
            tlpProgram.SuspendLayout();
            tlpWorkingDir.SuspendLayout();
            tlpBeforeStart.SuspendLayout();
            tlpLogs.SuspendLayout();
            tlpBackup.SuspendLayout();
            tlpBackupDir.SuspendLayout();
            tlpButtons.SuspendLayout();
            tlpCheckBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblGUID
            // 
            lblGUID.AutoSize = true;
            lblGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblGUID.Location = new System.Drawing.Point(4, 0);
            lblGUID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblGUID.Name = "lblGUID";
            lblGUID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            lblGUID.Size = new System.Drawing.Size(20, 19);
            lblGUID.TabIndex = 0;
            lblGUID.Text = "ID";
            // 
            // txtGUID
            // 
            txtGUID.Dock = System.Windows.Forms.DockStyle.Top;
            txtGUID.Location = new System.Drawing.Point(4, 22);
            txtGUID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtGUID.Name = "txtGUID";
            txtGUID.ReadOnly = true;
            txtGUID.Size = new System.Drawing.Size(661, 23);
            txtGUID.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblName.ForeColor = System.Drawing.Color.Red;
            lblName.Location = new System.Drawing.Point(4, 48);
            lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblName.Size = new System.Drawing.Size(39, 25);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // tlpGlobal
            // 
            tlpGlobal.ColumnCount = 1;
            tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpGlobal.Controls.Add(lblGUID, 0, 0);
            tlpGlobal.Controls.Add(txtGUID, 0, 1);
            tlpGlobal.Controls.Add(lblName, 0, 2);
            tlpGlobal.Controls.Add(txtName, 0, 3);
            tlpGlobal.Controls.Add(lblProgram, 0, 4);
            tlpGlobal.Controls.Add(tlpProgram, 0, 5);
            tlpGlobal.Controls.Add(lblArgs, 0, 6);
            tlpGlobal.Controls.Add(txtArgs, 0, 7);
            tlpGlobal.Controls.Add(lblWorkingDir, 0, 8);
            tlpGlobal.Controls.Add(tlpWorkingDir, 0, 9);
            tlpGlobal.Controls.Add(lblBeforeStart, 0, 10);
            tlpGlobal.Controls.Add(tlpBeforeStart, 0, 11);
            tlpGlobal.Controls.Add(lblLogs, 0, 12);
            tlpGlobal.Controls.Add(tlpLogs, 0, 13);
            tlpGlobal.Controls.Add(lblBackup, 0, 14);
            tlpGlobal.Controls.Add(tlpBackup, 0, 15);
            tlpGlobal.Controls.Add(lblBackupDir, 0, 16);
            tlpGlobal.Controls.Add(tlpBackupDir, 0, 17);
            tlpGlobal.Controls.Add(tlpButtons, 0, 19);
            tlpGlobal.Controls.Add(tlpCheckBox, 0, 18);
            tlpGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpGlobal.Location = new System.Drawing.Point(6, 6);
            tlpGlobal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpGlobal.Name = "tlpGlobal";
            tlpGlobal.RowCount = 20;
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.Size = new System.Drawing.Size(669, 717);
            tlpGlobal.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Dock = System.Windows.Forms.DockStyle.Top;
            txtName.Location = new System.Drawing.Point(4, 76);
            txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(661, 23);
            txtName.TabIndex = 3;
            // 
            // lblProgram
            // 
            lblProgram.AutoSize = true;
            lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblProgram.ForeColor = System.Drawing.Color.Red;
            lblProgram.Location = new System.Drawing.Point(4, 102);
            lblProgram.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProgram.Name = "lblProgram";
            lblProgram.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblProgram.Size = new System.Drawing.Size(53, 25);
            lblProgram.TabIndex = 4;
            lblProgram.Text = "Program";
            // 
            // tlpProgram
            // 
            tlpProgram.AutoSize = true;
            tlpProgram.ColumnCount = 2;
            tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tlpProgram.Controls.Add(butProgram, 1, 0);
            tlpProgram.Controls.Add(txtProgram, 0, 0);
            tlpProgram.Dock = System.Windows.Forms.DockStyle.Top;
            tlpProgram.Location = new System.Drawing.Point(4, 130);
            tlpProgram.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpProgram.Name = "tlpProgram";
            tlpProgram.RowCount = 1;
            tlpProgram.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpProgram.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpProgram.Size = new System.Drawing.Size(661, 27);
            tlpProgram.TabIndex = 5;
            // 
            // butProgram
            // 
            butProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            butProgram.Location = new System.Drawing.Point(632, 0);
            butProgram.Margin = new System.Windows.Forms.Padding(0);
            butProgram.Name = "butProgram";
            butProgram.Size = new System.Drawing.Size(29, 27);
            butProgram.TabIndex = 1;
            butProgram.Text = "...";
            butProgram.UseVisualStyleBackColor = true;
            butProgram.Click += butProgram_Click;
            // 
            // txtProgram
            // 
            txtProgram.Dock = System.Windows.Forms.DockStyle.Top;
            txtProgram.Location = new System.Drawing.Point(0, 0);
            txtProgram.Margin = new System.Windows.Forms.Padding(0);
            txtProgram.Name = "txtProgram";
            txtProgram.Size = new System.Drawing.Size(632, 23);
            txtProgram.TabIndex = 0;
            // 
            // lblArgs
            // 
            lblArgs.AutoSize = true;
            lblArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblArgs.Location = new System.Drawing.Point(4, 160);
            lblArgs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblArgs.Name = "lblArgs";
            lblArgs.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblArgs.Size = new System.Drawing.Size(66, 25);
            lblArgs.TabIndex = 6;
            lblArgs.Text = "Arguments";
            // 
            // txtArgs
            // 
            txtArgs.Dock = System.Windows.Forms.DockStyle.Top;
            txtArgs.Location = new System.Drawing.Point(4, 188);
            txtArgs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtArgs.Name = "txtArgs";
            txtArgs.Size = new System.Drawing.Size(661, 23);
            txtArgs.TabIndex = 7;
            // 
            // lblWorkingDir
            // 
            lblWorkingDir.AutoSize = true;
            lblWorkingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblWorkingDir.Location = new System.Drawing.Point(4, 214);
            lblWorkingDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWorkingDir.Name = "lblWorkingDir";
            lblWorkingDir.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblWorkingDir.Size = new System.Drawing.Size(107, 25);
            lblWorkingDir.TabIndex = 11;
            lblWorkingDir.Text = "Working directory";
            // 
            // tlpWorkingDir
            // 
            tlpWorkingDir.AutoSize = true;
            tlpWorkingDir.ColumnCount = 2;
            tlpWorkingDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpWorkingDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpWorkingDir.Controls.Add(butWorkingDir, 0, 0);
            tlpWorkingDir.Controls.Add(txtWorkingDir, 0, 0);
            tlpWorkingDir.Dock = System.Windows.Forms.DockStyle.Top;
            tlpWorkingDir.Location = new System.Drawing.Point(4, 242);
            tlpWorkingDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpWorkingDir.Name = "tlpWorkingDir";
            tlpWorkingDir.RowCount = 1;
            tlpWorkingDir.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpWorkingDir.Size = new System.Drawing.Size(661, 27);
            tlpWorkingDir.TabIndex = 12;
            // 
            // butWorkingDir
            // 
            butWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            butWorkingDir.Location = new System.Drawing.Point(632, 0);
            butWorkingDir.Margin = new System.Windows.Forms.Padding(0);
            butWorkingDir.Name = "butWorkingDir";
            butWorkingDir.Size = new System.Drawing.Size(29, 27);
            butWorkingDir.TabIndex = 2;
            butWorkingDir.Text = "...";
            butWorkingDir.UseVisualStyleBackColor = true;
            butWorkingDir.Click += butWorkingDir_Click;
            // 
            // txtWorkingDir
            // 
            txtWorkingDir.Dock = System.Windows.Forms.DockStyle.Top;
            txtWorkingDir.Location = new System.Drawing.Point(0, 0);
            txtWorkingDir.Margin = new System.Windows.Forms.Padding(0);
            txtWorkingDir.Name = "txtWorkingDir";
            txtWorkingDir.Size = new System.Drawing.Size(632, 23);
            txtWorkingDir.TabIndex = 1;
            // 
            // lblBeforeStart
            // 
            lblBeforeStart.AutoSize = true;
            lblBeforeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBeforeStart.Location = new System.Drawing.Point(4, 272);
            lblBeforeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBeforeStart.Name = "lblBeforeStart";
            lblBeforeStart.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblBeforeStart.Size = new System.Drawing.Size(73, 25);
            lblBeforeStart.TabIndex = 17;
            lblBeforeStart.Text = "Before start";
            // 
            // tlpBeforeStart
            // 
            tlpBeforeStart.AutoSize = true;
            tlpBeforeStart.ColumnCount = 2;
            tlpBeforeStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBeforeStart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpBeforeStart.Controls.Add(butBeforeStart, 0, 0);
            tlpBeforeStart.Controls.Add(txtBeforeStart, 0, 0);
            tlpBeforeStart.Dock = System.Windows.Forms.DockStyle.Top;
            tlpBeforeStart.Location = new System.Drawing.Point(4, 300);
            tlpBeforeStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpBeforeStart.Name = "tlpBeforeStart";
            tlpBeforeStart.RowCount = 1;
            tlpBeforeStart.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpBeforeStart.Size = new System.Drawing.Size(661, 27);
            tlpBeforeStart.TabIndex = 18;
            // 
            // butBeforeStart
            // 
            butBeforeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            butBeforeStart.Location = new System.Drawing.Point(632, 0);
            butBeforeStart.Margin = new System.Windows.Forms.Padding(0);
            butBeforeStart.Name = "butBeforeStart";
            butBeforeStart.Size = new System.Drawing.Size(29, 27);
            butBeforeStart.TabIndex = 2;
            butBeforeStart.Text = "...";
            butBeforeStart.UseVisualStyleBackColor = true;
            butBeforeStart.Click += butBeforeStart_Click;
            // 
            // txtBeforeStart
            // 
            txtBeforeStart.Dock = System.Windows.Forms.DockStyle.Top;
            txtBeforeStart.Location = new System.Drawing.Point(0, 0);
            txtBeforeStart.Margin = new System.Windows.Forms.Padding(0);
            txtBeforeStart.Name = "txtBeforeStart";
            txtBeforeStart.Size = new System.Drawing.Size(632, 23);
            txtBeforeStart.TabIndex = 1;
            // 
            // lblLogs
            // 
            lblLogs.AutoSize = true;
            lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLogs.Location = new System.Drawing.Point(4, 330);
            lblLogs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogs.Name = "lblLogs";
            lblLogs.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblLogs.Size = new System.Drawing.Size(34, 25);
            lblLogs.TabIndex = 8;
            lblLogs.Text = "Logs";
            // 
            // tlpLogs
            // 
            tlpLogs.AutoSize = true;
            tlpLogs.ColumnCount = 2;
            tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpLogs.Controls.Add(txtLogs, 0, 0);
            tlpLogs.Controls.Add(butLogs, 1, 0);
            tlpLogs.Dock = System.Windows.Forms.DockStyle.Top;
            tlpLogs.Location = new System.Drawing.Point(4, 358);
            tlpLogs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpLogs.Name = "tlpLogs";
            tlpLogs.RowCount = 1;
            tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpLogs.Size = new System.Drawing.Size(661, 27);
            tlpLogs.TabIndex = 9;
            // 
            // txtLogs
            // 
            txtLogs.Dock = System.Windows.Forms.DockStyle.Top;
            txtLogs.Location = new System.Drawing.Point(0, 0);
            txtLogs.Margin = new System.Windows.Forms.Padding(0);
            txtLogs.Name = "txtLogs";
            txtLogs.Size = new System.Drawing.Size(632, 23);
            txtLogs.TabIndex = 0;
            // 
            // butLogs
            // 
            butLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            butLogs.Location = new System.Drawing.Point(632, 0);
            butLogs.Margin = new System.Windows.Forms.Padding(0);
            butLogs.Name = "butLogs";
            butLogs.Size = new System.Drawing.Size(29, 27);
            butLogs.TabIndex = 1;
            butLogs.Text = "...";
            butLogs.UseVisualStyleBackColor = true;
            butLogs.Click += butLogs_Click;
            // 
            // lblBackup
            // 
            lblBackup.AutoSize = true;
            lblBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBackup.Location = new System.Drawing.Point(4, 388);
            lblBackup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblBackup.Name = "lblBackup";
            lblBackup.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblBackup.Size = new System.Drawing.Size(161, 25);
            lblBackup.TabIndex = 13;
            lblBackup.Text = "Files and folders to backup";
            // 
            // tlpBackup
            // 
            tlpBackup.ColumnCount = 2;
            tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tlpBackup.Controls.Add(lstBackup, 0, 0);
            tlpBackup.Controls.Add(butBackupAddFile, 1, 0);
            tlpBackup.Controls.Add(butBackupAddFolder, 1, 1);
            tlpBackup.Controls.Add(butBackupRemove, 1, 2);
            tlpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpBackup.Location = new System.Drawing.Point(4, 416);
            tlpBackup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpBackup.Name = "tlpBackup";
            tlpBackup.RowCount = 3;
            tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tlpBackup.Size = new System.Drawing.Size(661, 166);
            tlpBackup.TabIndex = 14;
            // 
            // lstBackup
            // 
            lstBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            lstBackup.FormattingEnabled = true;
            lstBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            lstBackup.IntegralHeight = false;
            lstBackup.Location = new System.Drawing.Point(0, 0);
            lstBackup.Margin = new System.Windows.Forms.Padding(0);
            lstBackup.Name = "lstBackup";
            tlpBackup.SetRowSpan(lstBackup, 3);
            lstBackup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            lstBackup.Size = new System.Drawing.Size(591, 166);
            lstBackup.TabIndex = 0;
            // 
            // butBackupAddFile
            // 
            butBackupAddFile.Dock = System.Windows.Forms.DockStyle.Fill;
            butBackupAddFile.Location = new System.Drawing.Point(591, 0);
            butBackupAddFile.Margin = new System.Windows.Forms.Padding(0);
            butBackupAddFile.Name = "butBackupAddFile";
            butBackupAddFile.Size = new System.Drawing.Size(70, 55);
            butBackupAddFile.TabIndex = 1;
            butBackupAddFile.Text = "Add file";
            butBackupAddFile.UseVisualStyleBackColor = true;
            butBackupAddFile.Click += butBackupAddFile_Click;
            // 
            // butBackupAddFolder
            // 
            butBackupAddFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            butBackupAddFolder.Location = new System.Drawing.Point(591, 55);
            butBackupAddFolder.Margin = new System.Windows.Forms.Padding(0);
            butBackupAddFolder.Name = "butBackupAddFolder";
            butBackupAddFolder.Size = new System.Drawing.Size(70, 55);
            butBackupAddFolder.TabIndex = 2;
            butBackupAddFolder.Text = "Add folder";
            butBackupAddFolder.UseVisualStyleBackColor = true;
            butBackupAddFolder.Click += butBackupAddFolder_Click;
            // 
            // butBackupRemove
            // 
            butBackupRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            butBackupRemove.Location = new System.Drawing.Point(591, 110);
            butBackupRemove.Margin = new System.Windows.Forms.Padding(0);
            butBackupRemove.Name = "butBackupRemove";
            butBackupRemove.Size = new System.Drawing.Size(70, 56);
            butBackupRemove.TabIndex = 3;
            butBackupRemove.Text = "Remove";
            butBackupRemove.UseVisualStyleBackColor = true;
            butBackupRemove.Click += butBackupRemove_Click;
            // 
            // lblBackupDir
            // 
            lblBackupDir.AutoSize = true;
            lblBackupDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblBackupDir.Location = new System.Drawing.Point(4, 591);
            lblBackupDir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 5);
            lblBackupDir.Name = "lblBackupDir";
            lblBackupDir.Size = new System.Drawing.Size(103, 13);
            lblBackupDir.TabIndex = 15;
            lblBackupDir.Text = "Backup directory";
            // 
            // tlpBackupDir
            // 
            tlpBackupDir.AutoSize = true;
            tlpBackupDir.ColumnCount = 2;
            tlpBackupDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpBackupDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tlpBackupDir.Controls.Add(butBackupDir, 1, 0);
            tlpBackupDir.Controls.Add(txtBackupDir, 0, 0);
            tlpBackupDir.Dock = System.Windows.Forms.DockStyle.Top;
            tlpBackupDir.Location = new System.Drawing.Point(4, 612);
            tlpBackupDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpBackupDir.Name = "tlpBackupDir";
            tlpBackupDir.RowCount = 1;
            tlpBackupDir.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpBackupDir.Size = new System.Drawing.Size(661, 27);
            tlpBackupDir.TabIndex = 16;
            // 
            // butBackupDir
            // 
            butBackupDir.Dock = System.Windows.Forms.DockStyle.Fill;
            butBackupDir.Location = new System.Drawing.Point(632, 0);
            butBackupDir.Margin = new System.Windows.Forms.Padding(0);
            butBackupDir.Name = "butBackupDir";
            butBackupDir.Size = new System.Drawing.Size(29, 27);
            butBackupDir.TabIndex = 3;
            butBackupDir.Text = "...";
            butBackupDir.UseVisualStyleBackColor = true;
            butBackupDir.Click += butBackupDir_Click;
            // 
            // txtBackupDir
            // 
            txtBackupDir.Dock = System.Windows.Forms.DockStyle.Top;
            txtBackupDir.Location = new System.Drawing.Point(0, 0);
            txtBackupDir.Margin = new System.Windows.Forms.Padding(0);
            txtBackupDir.Name = "txtBackupDir";
            txtBackupDir.Size = new System.Drawing.Size(632, 23);
            txtBackupDir.TabIndex = 4;
            // 
            // tlpButtons
            // 
            tlpButtons.ColumnCount = 2;
            tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpButtons.Controls.Add(butSave, 0, 0);
            tlpButtons.Controls.Add(butCancel, 1, 0);
            tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpButtons.Location = new System.Drawing.Point(4, 676);
            tlpButtons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpButtons.Size = new System.Drawing.Size(661, 38);
            tlpButtons.TabIndex = 10;
            // 
            // butSave
            // 
            butSave.Dock = System.Windows.Forms.DockStyle.Fill;
            butSave.Location = new System.Drawing.Point(0, 0);
            butSave.Margin = new System.Windows.Forms.Padding(0);
            butSave.Name = "butSave";
            butSave.Size = new System.Drawing.Size(330, 38);
            butSave.TabIndex = 0;
            butSave.Text = "Save";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += butSave_Click;
            // 
            // butCancel
            // 
            butCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            butCancel.Location = new System.Drawing.Point(330, 0);
            butCancel.Margin = new System.Windows.Forms.Padding(0);
            butCancel.Name = "butCancel";
            butCancel.Size = new System.Drawing.Size(331, 38);
            butCancel.TabIndex = 1;
            butCancel.Text = "Cancel";
            butCancel.UseVisualStyleBackColor = true;
            butCancel.Click += butCancel_Click;
            // 
            // tlpCheckBox
            // 
            tlpCheckBox.ColumnCount = 2;
            tlpCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCheckBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCheckBox.Controls.Add(cbAutoStart, 0, 0);
            tlpCheckBox.Controls.Add(cbAutoRestartOnCrash, 1, 0);
            tlpCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpCheckBox.Location = new System.Drawing.Point(3, 645);
            tlpCheckBox.Name = "tlpCheckBox";
            tlpCheckBox.RowCount = 1;
            tlpCheckBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCheckBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpCheckBox.Size = new System.Drawing.Size(663, 25);
            tlpCheckBox.TabIndex = 19;
            // 
            // cbAutoStart
            // 
            cbAutoStart.AutoSize = true;
            cbAutoStart.Dock = System.Windows.Forms.DockStyle.Fill;
            cbAutoStart.Location = new System.Drawing.Point(3, 3);
            cbAutoStart.Name = "cbAutoStart";
            cbAutoStart.Size = new System.Drawing.Size(325, 19);
            cbAutoStart.TabIndex = 0;
            cbAutoStart.Text = "Auto start at Startup";
            cbAutoStart.UseVisualStyleBackColor = true;
            cbAutoStart.CheckedChanged += cbAutoStart_CheckedChanged;
            // 
            // cbAutoRestartOnCrash
            // 
            cbAutoRestartOnCrash.AutoSize = true;
            cbAutoRestartOnCrash.Dock = System.Windows.Forms.DockStyle.Fill;
            cbAutoRestartOnCrash.Enabled = false;
            cbAutoRestartOnCrash.Location = new System.Drawing.Point(334, 3);
            cbAutoRestartOnCrash.Name = "cbAutoRestartOnCrash";
            cbAutoRestartOnCrash.Size = new System.Drawing.Size(326, 19);
            cbAutoRestartOnCrash.TabIndex = 1;
            cbAutoRestartOnCrash.Text = "Auto restart on Crash";
            cbAutoRestartOnCrash.UseVisualStyleBackColor = true;
            cbAutoRestartOnCrash.CheckedChanged += cbAutoRestartOnCrash_CheckedChanged;
            // 
            // folderBrowserDialogCtrl
            // 
            folderBrowserDialogCtrl.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // frmGameConfig
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(681, 729);
            Controls.Add(tlpGlobal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGameConfig";
            Padding = new System.Windows.Forms.Padding(6);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Game configuration";
            Shown += frmGameConfig_Shown;
            tlpGlobal.ResumeLayout(false);
            tlpGlobal.PerformLayout();
            tlpProgram.ResumeLayout(false);
            tlpProgram.PerformLayout();
            tlpWorkingDir.ResumeLayout(false);
            tlpWorkingDir.PerformLayout();
            tlpBeforeStart.ResumeLayout(false);
            tlpBeforeStart.PerformLayout();
            tlpLogs.ResumeLayout(false);
            tlpLogs.PerformLayout();
            tlpBackup.ResumeLayout(false);
            tlpBackupDir.ResumeLayout(false);
            tlpBackupDir.PerformLayout();
            tlpButtons.ResumeLayout(false);
            tlpCheckBox.ResumeLayout(false);
            tlpCheckBox.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGUID;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TableLayoutPanel tlpGlobal;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.TableLayoutPanel tlpProgram;
        private System.Windows.Forms.Button butProgram;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.OpenFileDialog openFileDialogCtrl;
        private System.Windows.Forms.Label lblArgs;
        private System.Windows.Forms.TextBox txtArgs;
        private System.Windows.Forms.Label lblLogs;
        private System.Windows.Forms.TableLayoutPanel tlpLogs;
        private System.Windows.Forms.Button butLogs;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.Label lblWorkingDir;
        private System.Windows.Forms.TableLayoutPanel tlpWorkingDir;
        private System.Windows.Forms.TextBox txtWorkingDir;
        private System.Windows.Forms.Button butWorkingDir;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCtrl;
        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.TableLayoutPanel tlpBackup;
        private System.Windows.Forms.ListBox lstBackup;
        private System.Windows.Forms.Button butBackupAddFile;
        private System.Windows.Forms.Button butBackupAddFolder;
        private System.Windows.Forms.Button butBackupRemove;
        private System.Windows.Forms.Label lblBackupDir;
        private System.Windows.Forms.TableLayoutPanel tlpBackupDir;
        private System.Windows.Forms.Button butBackupDir;
        private System.Windows.Forms.TextBox txtBackupDir;
        private System.Windows.Forms.TableLayoutPanel tlpBeforeStart;
        private System.Windows.Forms.Button butBeforeStart;
        private System.Windows.Forms.TextBox txtBeforeStart;
        private System.Windows.Forms.Label lblBeforeStart;
        private System.Windows.Forms.TableLayoutPanel tlpCheckBox;
        private System.Windows.Forms.CheckBox cbAutoStart;
        private System.Windows.Forms.CheckBox cbAutoRestartOnCrash;
    }
}

