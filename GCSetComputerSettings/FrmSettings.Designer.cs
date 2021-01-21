
namespace GCSetComputerSettings
{
    partial class FrmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            this.tlpGlobal = new System.Windows.Forms.TableLayoutPanel();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.butSave = new System.Windows.Forms.Button();
            this.tlpListenPort = new System.Windows.Forms.TableLayoutPanel();
            this.butRemoveListenPort = new System.Windows.Forms.Button();
            this.butGetListenPort = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.butAddFirewall = new System.Windows.Forms.Button();
            this.butRemoveFirewall = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.tlpGlobal.SuspendLayout();
            this.tlpListenPort.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpGlobal
            // 
            this.tlpGlobal.ColumnCount = 1;
            this.tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpGlobal.Controls.Add(this.lblPort, 0, 0);
            this.tlpGlobal.Controls.Add(this.txtPort, 0, 1);
            this.tlpGlobal.Controls.Add(this.butSave, 0, 6);
            this.tlpGlobal.Controls.Add(this.tlpListenPort, 0, 7);
            this.tlpGlobal.Controls.Add(this.tableLayoutPanel1, 0, 8);
            this.tlpGlobal.Controls.Add(this.lblLogin, 0, 2);
            this.tlpGlobal.Controls.Add(this.lblPassword, 0, 4);
            this.tlpGlobal.Controls.Add(this.txtLogin, 0, 3);
            this.tlpGlobal.Controls.Add(this.txtPassword, 0, 5);
            this.tlpGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGlobal.Location = new System.Drawing.Point(5, 5);
            this.tlpGlobal.Name = "tlpGlobal";
            this.tlpGlobal.RowCount = 8;
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpGlobal.Size = new System.Drawing.Size(394, 364);
            this.tlpGlobal.TabIndex = 0;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.ForeColor = System.Drawing.Color.Red;
            this.lblPort.Location = new System.Drawing.Point(3, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblPort.Size = new System.Drawing.Size(95, 18);
            this.lblPort.TabIndex = 0;
            this.lblPort.Text = "Webserver Port";
            // 
            // txtPort
            // 
            this.txtPort.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPort.Location = new System.Drawing.Point(3, 21);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(388, 20);
            this.txtPort.TabIndex = 1;
            // 
            // butSave
            // 
            this.butSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butSave.Enabled = false;
            this.butSave.Location = new System.Drawing.Point(3, 145);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(388, 44);
            this.butSave.TabIndex = 4;
            this.butSave.Text = "Save changes";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // tlpListenPort
            // 
            this.tlpListenPort.ColumnCount = 2;
            this.tlpListenPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListenPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListenPort.Controls.Add(this.butRemoveListenPort, 1, 0);
            this.tlpListenPort.Controls.Add(this.butGetListenPort, 0, 0);
            this.tlpListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpListenPort.Location = new System.Drawing.Point(0, 192);
            this.tlpListenPort.Margin = new System.Windows.Forms.Padding(0);
            this.tlpListenPort.Name = "tlpListenPort";
            this.tlpListenPort.RowCount = 1;
            this.tlpListenPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListenPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpListenPort.Size = new System.Drawing.Size(394, 50);
            this.tlpListenPort.TabIndex = 5;
            // 
            // butRemoveListenPort
            // 
            this.butRemoveListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRemoveListenPort.Location = new System.Drawing.Point(200, 3);
            this.butRemoveListenPort.Name = "butRemoveListenPort";
            this.butRemoveListenPort.Size = new System.Drawing.Size(191, 44);
            this.butRemoveListenPort.TabIndex = 3;
            this.butRemoveListenPort.Text = "Remove rights to listen on this port";
            this.butRemoveListenPort.UseVisualStyleBackColor = true;
            this.butRemoveListenPort.Click += new System.EventHandler(this.butRemoveListenPort_Click);
            // 
            // butGetListenPort
            // 
            this.butGetListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butGetListenPort.Location = new System.Drawing.Point(3, 3);
            this.butGetListenPort.Name = "butGetListenPort";
            this.butGetListenPort.Size = new System.Drawing.Size(191, 44);
            this.butGetListenPort.TabIndex = 2;
            this.butGetListenPort.Text = "Get rights to listen on this port";
            this.butGetListenPort.UseVisualStyleBackColor = true;
            this.butGetListenPort.Click += new System.EventHandler(this.butListenPort_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.butAddFirewall, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.butRemoveFirewall, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 242);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 122);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // butAddFirewall
            // 
            this.butAddFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butAddFirewall.Location = new System.Drawing.Point(3, 3);
            this.butAddFirewall.Name = "butAddFirewall";
            this.butAddFirewall.Size = new System.Drawing.Size(191, 116);
            this.butAddFirewall.TabIndex = 3;
            this.butAddFirewall.Text = "Open port in firewall";
            this.butAddFirewall.UseVisualStyleBackColor = true;
            this.butAddFirewall.Click += new System.EventHandler(this.butFirewall_Click);
            // 
            // butRemoveFirewall
            // 
            this.butRemoveFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.butRemoveFirewall.Location = new System.Drawing.Point(200, 3);
            this.butRemoveFirewall.Name = "butRemoveFirewall";
            this.butRemoveFirewall.Size = new System.Drawing.Size(191, 116);
            this.butRemoveFirewall.TabIndex = 4;
            this.butRemoveFirewall.Text = "Remove firewall rules for GC";
            this.butRemoveFirewall.UseVisualStyleBackColor = true;
            this.butRemoveFirewall.Click += new System.EventHandler(this.butRemoveFirewall_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.Red;
            this.lblLogin.Location = new System.Drawing.Point(3, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblLogin.Size = new System.Drawing.Size(103, 23);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Webserver Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Red;
            this.lblPassword.Location = new System.Drawing.Point(3, 93);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblPassword.Size = new System.Drawing.Size(126, 23);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Webserver Password";
            // 
            // txtLogin
            // 
            this.txtLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLogin.Location = new System.Drawing.Point(3, 70);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(388, 20);
            this.txtLogin.TabIndex = 9;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassword.Location = new System.Drawing.Point(3, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(388, 20);
            this.txtPassword.TabIndex = 10;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 374);
            this.Controls.Add(this.tlpGlobal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSettings";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Gameserver Control Set Computer Settings";
            this.tlpGlobal.ResumeLayout(false);
            this.tlpGlobal.PerformLayout();
            this.tlpListenPort.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGlobal;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button butGetListenPort;
        private System.Windows.Forms.Button butAddFirewall;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.TableLayoutPanel tlpListenPort;
        private System.Windows.Forms.Button butRemoveListenPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button butRemoveFirewall;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

