
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
            this.lblGUID = new System.Windows.Forms.Label();
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tlpGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.lblWorkingDir = new System.Windows.Forms.Label();
            this.lblLogs = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.tlpProgram = new System.Windows.Forms.TableLayoutPanel();
            this.butProgram = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.lblArgs = new System.Windows.Forms.Label();
            this.txtArgs = new System.Windows.Forms.TextBox();
            this.tlpLogs = new System.Windows.Forms.TableLayoutPanel();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.butLogs = new System.Windows.Forms.Button();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.tlpWorkingDir = new System.Windows.Forms.TableLayoutPanel();
            this.butWorkingDir = new System.Windows.Forms.Button();
            this.txtWorkingDir = new System.Windows.Forms.TextBox();
            this.lblBackup = new System.Windows.Forms.Label();
            this.tlpBackup = new System.Windows.Forms.TableLayoutPanel();
            this.lstBackup = new System.Windows.Forms.ListBox();
            this.butBackupAddFile = new System.Windows.Forms.Button();
            this.butBackupAddFolder = new System.Windows.Forms.Button();
            this.butBackupRemove = new System.Windows.Forms.Button();
            this.lblBackupDir = new System.Windows.Forms.Label();
            this.tlpBackupDir = new System.Windows.Forms.TableLayoutPanel();
            this.butBackupDir = new System.Windows.Forms.Button();
            this.txtBackupDir = new System.Windows.Forms.TextBox();
            this.openFileDialogCtrl = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogCtrl = new System.Windows.Forms.FolderBrowserDialog();
            this.tlpGlobal.SuspendLayout();
            this.tlpProgram.SuspendLayout();
            this.tlpLogs.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpWorkingDir.SuspendLayout();
            this.tlpBackup.SuspendLayout();
            this.tlpBackupDir.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblGUID
            // 
            this.lblGUID.AutoSize = true;
            this.lblGUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGUID.Location = new System.Drawing.Point(3, 0);
            this.lblGUID.Name = "lblGUID";
            this.lblGUID.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGUID.Size = new System.Drawing.Size(20, 18);
            this.lblGUID.TabIndex = 0;
            this.lblGUID.Text = "ID";
            // 
            // txtGUID
            // 
            this.txtGUID.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGUID.Location = new System.Drawing.Point(3, 21);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.ReadOnly = true;
            this.txtGUID.Size = new System.Drawing.Size(568, 20);
            this.txtGUID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(3, 44);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblName.Size = new System.Drawing.Size(39, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // tlpGlobal
            // 
            this.tlpGlobal.ColumnCount = 1;
            this.tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGlobal.Controls.Add(this.lblWorkingDir, 0, 8);
            this.tlpGlobal.Controls.Add(this.lblLogs, 0, 10);
            this.tlpGlobal.Controls.Add(this.lblGUID, 0, 0);
            this.tlpGlobal.Controls.Add(this.txtGUID, 0, 1);
            this.tlpGlobal.Controls.Add(this.lblName, 0, 2);
            this.tlpGlobal.Controls.Add(this.txtName, 0, 3);
            this.tlpGlobal.Controls.Add(this.lblProgram, 0, 4);
            this.tlpGlobal.Controls.Add(this.tlpProgram, 0, 5);
            this.tlpGlobal.Controls.Add(this.lblArgs, 0, 6);
            this.tlpGlobal.Controls.Add(this.txtArgs, 0, 7);
            this.tlpGlobal.Controls.Add(this.tlpLogs, 0, 11);
            this.tlpGlobal.Controls.Add(this.tlpButtons, 0, 16);
            this.tlpGlobal.Controls.Add(this.tlpWorkingDir, 0, 9);
            this.tlpGlobal.Controls.Add(this.lblBackup, 0, 12);
            this.tlpGlobal.Controls.Add(this.tlpBackup, 0, 13);
            this.tlpGlobal.Controls.Add(this.lblBackupDir, 0, 14);
            this.tlpGlobal.Controls.Add(this.tlpBackupDir, 0, 15);
            this.tlpGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGlobal.Location = new System.Drawing.Point(5, 5);
            this.tlpGlobal.Name = "tlpGlobal";
            this.tlpGlobal.RowCount = 17;
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpGlobal.Size = new System.Drawing.Size(574, 556);
            this.tlpGlobal.TabIndex = 0;
            // 
            // lblWorkingDir
            // 
            this.lblWorkingDir.AutoSize = true;
            this.lblWorkingDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkingDir.Location = new System.Drawing.Point(3, 191);
            this.lblWorkingDir.Name = "lblWorkingDir";
            this.lblWorkingDir.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblWorkingDir.Size = new System.Drawing.Size(107, 23);
            this.lblWorkingDir.TabIndex = 11;
            this.lblWorkingDir.Text = "Working directory";
            // 
            // lblLogs
            // 
            this.lblLogs.AutoSize = true;
            this.lblLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogs.Location = new System.Drawing.Point(3, 240);
            this.lblLogs.Name = "lblLogs";
            this.lblLogs.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblLogs.Size = new System.Drawing.Size(34, 23);
            this.lblLogs.TabIndex = 8;
            this.lblLogs.Text = "Logs";
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.Location = new System.Drawing.Point(3, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(568, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.ForeColor = System.Drawing.Color.Red;
            this.lblProgram.Location = new System.Drawing.Point(3, 93);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblProgram.Size = new System.Drawing.Size(53, 23);
            this.lblProgram.TabIndex = 4;
            this.lblProgram.Text = "Program";
            // 
            // tlpProgram
            // 
            this.tlpProgram.AutoSize = true;
            this.tlpProgram.ColumnCount = 2;
            this.tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpProgram.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpProgram.Controls.Add(this.butProgram, 1, 0);
            this.tlpProgram.Controls.Add(this.txtProgram, 0, 0);
            this.tlpProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpProgram.Location = new System.Drawing.Point(3, 119);
            this.tlpProgram.Name = "tlpProgram";
            this.tlpProgram.RowCount = 1;
            this.tlpProgram.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpProgram.Size = new System.Drawing.Size(568, 20);
            this.tlpProgram.TabIndex = 5;
            // 
            // butProgram
            // 
            this.butProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butProgram.Location = new System.Drawing.Point(543, 0);
            this.butProgram.Margin = new System.Windows.Forms.Padding(0);
            this.butProgram.Name = "butProgram";
            this.butProgram.Size = new System.Drawing.Size(25, 20);
            this.butProgram.TabIndex = 1;
            this.butProgram.Text = "...";
            this.butProgram.UseVisualStyleBackColor = true;
            this.butProgram.Click += new System.EventHandler(this.butProgram_Click);
            // 
            // txtProgram
            // 
            this.txtProgram.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProgram.Location = new System.Drawing.Point(0, 0);
            this.txtProgram.Margin = new System.Windows.Forms.Padding(0);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(543, 20);
            this.txtProgram.TabIndex = 0;
            // 
            // lblArgs
            // 
            this.lblArgs.AutoSize = true;
            this.lblArgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgs.Location = new System.Drawing.Point(3, 142);
            this.lblArgs.Name = "lblArgs";
            this.lblArgs.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblArgs.Size = new System.Drawing.Size(66, 23);
            this.lblArgs.TabIndex = 6;
            this.lblArgs.Text = "Arguments";
            // 
            // txtArgs
            // 
            this.txtArgs.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtArgs.Location = new System.Drawing.Point(3, 168);
            this.txtArgs.Name = "txtArgs";
            this.txtArgs.Size = new System.Drawing.Size(568, 20);
            this.txtArgs.TabIndex = 7;
            // 
            // tlpLogs
            // 
            this.tlpLogs.AutoSize = true;
            this.tlpLogs.ColumnCount = 2;
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpLogs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpLogs.Controls.Add(this.txtLogs, 0, 0);
            this.tlpLogs.Controls.Add(this.butLogs, 1, 0);
            this.tlpLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLogs.Location = new System.Drawing.Point(3, 266);
            this.tlpLogs.Name = "tlpLogs";
            this.tlpLogs.RowCount = 1;
            this.tlpLogs.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLogs.Size = new System.Drawing.Size(568, 20);
            this.tlpLogs.TabIndex = 9;
            // 
            // txtLogs
            // 
            this.txtLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogs.Location = new System.Drawing.Point(0, 0);
            this.txtLogs.Margin = new System.Windows.Forms.Padding(0);
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.Size = new System.Drawing.Size(543, 20);
            this.txtLogs.TabIndex = 0;
            // 
            // butLogs
            // 
            this.butLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butLogs.Location = new System.Drawing.Point(543, 0);
            this.butLogs.Margin = new System.Windows.Forms.Padding(0);
            this.butLogs.Name = "butLogs";
            this.butLogs.Size = new System.Drawing.Size(25, 20);
            this.butLogs.TabIndex = 1;
            this.butLogs.Text = "...";
            this.butLogs.UseVisualStyleBackColor = true;
            this.butLogs.Click += new System.EventHandler(this.butLogs_Click);
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.butSave, 0, 0);
            this.tlpButtons.Controls.Add(this.butCancel, 1, 0);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 513);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 1;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpButtons.Size = new System.Drawing.Size(568, 40);
            this.tlpButtons.TabIndex = 10;
            // 
            // butSave
            // 
            this.butSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSave.Location = new System.Drawing.Point(0, 0);
            this.butSave.Margin = new System.Windows.Forms.Padding(0);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(284, 40);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butCancel.Location = new System.Drawing.Point(284, 0);
            this.butCancel.Margin = new System.Windows.Forms.Padding(0);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(284, 40);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // tlpWorkingDir
            // 
            this.tlpWorkingDir.AutoSize = true;
            this.tlpWorkingDir.ColumnCount = 2;
            this.tlpWorkingDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpWorkingDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpWorkingDir.Controls.Add(this.butWorkingDir, 0, 0);
            this.tlpWorkingDir.Controls.Add(this.txtWorkingDir, 0, 0);
            this.tlpWorkingDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpWorkingDir.Location = new System.Drawing.Point(3, 217);
            this.tlpWorkingDir.Name = "tlpWorkingDir";
            this.tlpWorkingDir.RowCount = 1;
            this.tlpWorkingDir.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpWorkingDir.Size = new System.Drawing.Size(568, 20);
            this.tlpWorkingDir.TabIndex = 12;
            // 
            // butWorkingDir
            // 
            this.butWorkingDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butWorkingDir.Location = new System.Drawing.Point(543, 0);
            this.butWorkingDir.Margin = new System.Windows.Forms.Padding(0);
            this.butWorkingDir.Name = "butWorkingDir";
            this.butWorkingDir.Size = new System.Drawing.Size(25, 20);
            this.butWorkingDir.TabIndex = 2;
            this.butWorkingDir.Text = "...";
            this.butWorkingDir.UseVisualStyleBackColor = true;
            this.butWorkingDir.Click += new System.EventHandler(this.butWorkingDir_Click);
            // 
            // txtWorkingDir
            // 
            this.txtWorkingDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtWorkingDir.Location = new System.Drawing.Point(0, 0);
            this.txtWorkingDir.Margin = new System.Windows.Forms.Padding(0);
            this.txtWorkingDir.Name = "txtWorkingDir";
            this.txtWorkingDir.Size = new System.Drawing.Size(543, 20);
            this.txtWorkingDir.TabIndex = 1;
            // 
            // lblBackup
            // 
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(3, 289);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblBackup.Size = new System.Drawing.Size(161, 23);
            this.lblBackup.TabIndex = 13;
            this.lblBackup.Text = "Files and folders to backup";
            // 
            // tlpBackup
            // 
            this.tlpBackup.ColumnCount = 2;
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackup.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpBackup.Controls.Add(this.lstBackup, 0, 0);
            this.tlpBackup.Controls.Add(this.butBackupAddFile, 1, 0);
            this.tlpBackup.Controls.Add(this.butBackupAddFolder, 1, 1);
            this.tlpBackup.Controls.Add(this.butBackupRemove, 1, 2);
            this.tlpBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBackup.Location = new System.Drawing.Point(3, 315);
            this.tlpBackup.Name = "tlpBackup";
            this.tlpBackup.RowCount = 3;
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBackup.Size = new System.Drawing.Size(568, 144);
            this.tlpBackup.TabIndex = 14;
            // 
            // lstBackup
            // 
            this.lstBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBackup.FormattingEnabled = true;
            this.lstBackup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstBackup.IntegralHeight = false;
            this.lstBackup.Location = new System.Drawing.Point(0, 0);
            this.lstBackup.Margin = new System.Windows.Forms.Padding(0);
            this.lstBackup.Name = "lstBackup";
            this.tlpBackup.SetRowSpan(this.lstBackup, 3);
            this.lstBackup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBackup.Size = new System.Drawing.Size(508, 144);
            this.lstBackup.TabIndex = 0;
            // 
            // butBackupAddFile
            // 
            this.butBackupAddFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBackupAddFile.Location = new System.Drawing.Point(508, 0);
            this.butBackupAddFile.Margin = new System.Windows.Forms.Padding(0);
            this.butBackupAddFile.Name = "butBackupAddFile";
            this.butBackupAddFile.Size = new System.Drawing.Size(60, 48);
            this.butBackupAddFile.TabIndex = 1;
            this.butBackupAddFile.Text = "Add file";
            this.butBackupAddFile.UseVisualStyleBackColor = true;
            this.butBackupAddFile.Click += new System.EventHandler(this.butBackupAddFile_Click);
            // 
            // butBackupAddFolder
            // 
            this.butBackupAddFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBackupAddFolder.Location = new System.Drawing.Point(508, 48);
            this.butBackupAddFolder.Margin = new System.Windows.Forms.Padding(0);
            this.butBackupAddFolder.Name = "butBackupAddFolder";
            this.butBackupAddFolder.Size = new System.Drawing.Size(60, 48);
            this.butBackupAddFolder.TabIndex = 2;
            this.butBackupAddFolder.Text = "Add folder";
            this.butBackupAddFolder.UseVisualStyleBackColor = true;
            this.butBackupAddFolder.Click += new System.EventHandler(this.butBackupAddFolder_Click);
            // 
            // butBackupRemove
            // 
            this.butBackupRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBackupRemove.Location = new System.Drawing.Point(508, 96);
            this.butBackupRemove.Margin = new System.Windows.Forms.Padding(0);
            this.butBackupRemove.Name = "butBackupRemove";
            this.butBackupRemove.Size = new System.Drawing.Size(60, 48);
            this.butBackupRemove.TabIndex = 3;
            this.butBackupRemove.Text = "Remove";
            this.butBackupRemove.UseVisualStyleBackColor = true;
            this.butBackupRemove.Click += new System.EventHandler(this.butBackupRemove_Click);
            // 
            // lblBackupDir
            // 
            this.lblBackupDir.AutoSize = true;
            this.lblBackupDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupDir.Location = new System.Drawing.Point(3, 467);
            this.lblBackupDir.Margin = new System.Windows.Forms.Padding(3, 5, 3, 4);
            this.lblBackupDir.Name = "lblBackupDir";
            this.lblBackupDir.Size = new System.Drawing.Size(103, 13);
            this.lblBackupDir.TabIndex = 15;
            this.lblBackupDir.Text = "Backup directory";
            // 
            // tlpBackupDir
            // 
            this.tlpBackupDir.AutoSize = true;
            this.tlpBackupDir.ColumnCount = 2;
            this.tlpBackupDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBackupDir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpBackupDir.Controls.Add(this.butBackupDir, 1, 0);
            this.tlpBackupDir.Controls.Add(this.txtBackupDir, 0, 0);
            this.tlpBackupDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpBackupDir.Location = new System.Drawing.Point(3, 487);
            this.tlpBackupDir.Name = "tlpBackupDir";
            this.tlpBackupDir.RowCount = 1;
            this.tlpBackupDir.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBackupDir.Size = new System.Drawing.Size(568, 20);
            this.tlpBackupDir.TabIndex = 16;
            // 
            // butBackupDir
            // 
            this.butBackupDir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butBackupDir.Location = new System.Drawing.Point(543, 0);
            this.butBackupDir.Margin = new System.Windows.Forms.Padding(0);
            this.butBackupDir.Name = "butBackupDir";
            this.butBackupDir.Size = new System.Drawing.Size(25, 20);
            this.butBackupDir.TabIndex = 3;
            this.butBackupDir.Text = "...";
            this.butBackupDir.UseVisualStyleBackColor = true;
            this.butBackupDir.Click += new System.EventHandler(this.butBackupDir_Click);
            // 
            // txtBackupDir
            // 
            this.txtBackupDir.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBackupDir.Location = new System.Drawing.Point(0, 0);
            this.txtBackupDir.Margin = new System.Windows.Forms.Padding(0);
            this.txtBackupDir.Name = "txtBackupDir";
            this.txtBackupDir.Size = new System.Drawing.Size(543, 20);
            this.txtBackupDir.TabIndex = 4;
            // 
            // folderBrowserDialogCtrl
            // 
            this.folderBrowserDialogCtrl.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // frmGameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 566);
            this.Controls.Add(this.tlpGlobal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGameConfig";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game configuration";
            this.tlpGlobal.ResumeLayout(false);
            this.tlpGlobal.PerformLayout();
            this.tlpProgram.ResumeLayout(false);
            this.tlpProgram.PerformLayout();
            this.tlpLogs.ResumeLayout(false);
            this.tlpLogs.PerformLayout();
            this.tlpButtons.ResumeLayout(false);
            this.tlpWorkingDir.ResumeLayout(false);
            this.tlpWorkingDir.PerformLayout();
            this.tlpBackup.ResumeLayout(false);
            this.tlpBackupDir.ResumeLayout(false);
            this.tlpBackupDir.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

