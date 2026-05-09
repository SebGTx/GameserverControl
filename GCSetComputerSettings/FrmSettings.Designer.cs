
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettings));
            tlpGlobal = new System.Windows.Forms.TableLayoutPanel();
            lblPort = new System.Windows.Forms.Label();
            txtPort = new System.Windows.Forms.TextBox();
            lblLogin = new System.Windows.Forms.Label();
            txtLogin = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            butSave = new System.Windows.Forms.Button();
            tlpListenPort = new System.Windows.Forms.TableLayoutPanel();
            butAddRightsListenPort = new System.Windows.Forms.Button();
            butRemoveRightsListenPort = new System.Windows.Forms.Button();
            tplFirewall = new System.Windows.Forms.TableLayoutPanel();
            butAddFirewall = new System.Windows.Forms.Button();
            butRemoveFirewall = new System.Windows.Forms.Button();
            tplStartWithWindows = new System.Windows.Forms.TableLayoutPanel();
            butEnableStartWithWindows = new System.Windows.Forms.Button();
            butDisableStartWithWindows = new System.Windows.Forms.Button();
            toolTipPort = new System.Windows.Forms.ToolTip(components);
            tlpGlobal.SuspendLayout();
            tlpListenPort.SuspendLayout();
            tplFirewall.SuspendLayout();
            tplStartWithWindows.SuspendLayout();
            SuspendLayout();
            // 
            // tlpGlobal
            // 
            tlpGlobal.ColumnCount = 1;
            tlpGlobal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpGlobal.Controls.Add(lblPort, 0, 0);
            tlpGlobal.Controls.Add(txtPort, 0, 1);
            tlpGlobal.Controls.Add(lblLogin, 0, 2);
            tlpGlobal.Controls.Add(txtLogin, 0, 3);
            tlpGlobal.Controls.Add(lblPassword, 0, 4);
            tlpGlobal.Controls.Add(txtPassword, 0, 5);
            tlpGlobal.Controls.Add(butSave, 0, 6);
            tlpGlobal.Controls.Add(tlpListenPort, 0, 7);
            tlpGlobal.Controls.Add(tplFirewall, 0, 8);
            tlpGlobal.Controls.Add(tplStartWithWindows, 0, 9);
            tlpGlobal.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpGlobal.Location = new System.Drawing.Point(6, 6);
            tlpGlobal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tlpGlobal.Name = "tlpGlobal";
            tlpGlobal.RowCount = 10;
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            tlpGlobal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tlpGlobal.Size = new System.Drawing.Size(459, 385);
            tlpGlobal.TabIndex = 0;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPort.ForeColor = System.Drawing.Color.Red;
            lblPort.Location = new System.Drawing.Point(4, 0);
            lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPort.Name = "lblPort";
            lblPort.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            lblPort.Size = new System.Drawing.Size(95, 19);
            lblPort.TabIndex = 0;
            lblPort.Text = "Webserver Port";
            // 
            // txtPort
            // 
            txtPort.Dock = System.Windows.Forms.DockStyle.Top;
            txtPort.ForeColor = System.Drawing.SystemColors.WindowText;
            txtPort.Location = new System.Drawing.Point(4, 22);
            txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(451, 23);
            txtPort.TabIndex = 1;
            txtPort.Text = "fgdgdf";
            toolTipPort.SetToolTip(txtPort, "Listen port and Firewall rules must be removed to change the webserver port");
            txtPort.ReadOnlyChanged += txtPort_ReadOnlyChanged;
            txtPort.TextChanged += txtPort_TextChanged;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblLogin.ForeColor = System.Drawing.Color.Red;
            lblLogin.Location = new System.Drawing.Point(4, 48);
            lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblLogin.Size = new System.Drawing.Size(103, 25);
            lblLogin.TabIndex = 7;
            lblLogin.Text = "Webserver Login";
            // 
            // txtLogin
            // 
            txtLogin.Dock = System.Windows.Forms.DockStyle.Top;
            txtLogin.Location = new System.Drawing.Point(4, 76);
            txtLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new System.Drawing.Size(451, 23);
            txtLogin.TabIndex = 9;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblPassword.ForeColor = System.Drawing.Color.Red;
            lblPassword.Location = new System.Drawing.Point(4, 102);
            lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            lblPassword.Size = new System.Drawing.Size(126, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Webserver Password";
            // 
            // txtPassword
            // 
            txtPassword.Dock = System.Windows.Forms.DockStyle.Top;
            txtPassword.Location = new System.Drawing.Point(4, 130);
            txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new System.Drawing.Size(451, 23);
            txtPassword.TabIndex = 10;
            // 
            // butSave
            // 
            butSave.Dock = System.Windows.Forms.DockStyle.Fill;
            butSave.Enabled = false;
            butSave.Location = new System.Drawing.Point(4, 159);
            butSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butSave.Name = "butSave";
            butSave.Size = new System.Drawing.Size(451, 52);
            butSave.TabIndex = 4;
            butSave.Text = "Save changes";
            butSave.UseVisualStyleBackColor = true;
            butSave.Click += butSave_Click;
            // 
            // tlpListenPort
            // 
            tlpListenPort.ColumnCount = 2;
            tlpListenPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpListenPort.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpListenPort.Controls.Add(butAddRightsListenPort, 0, 0);
            tlpListenPort.Controls.Add(butRemoveRightsListenPort, 1, 0);
            tlpListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpListenPort.Location = new System.Drawing.Point(0, 214);
            tlpListenPort.Margin = new System.Windows.Forms.Padding(0);
            tlpListenPort.Name = "tlpListenPort";
            tlpListenPort.RowCount = 1;
            tlpListenPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpListenPort.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpListenPort.Size = new System.Drawing.Size(459, 58);
            tlpListenPort.TabIndex = 5;
            // 
            // butAddRightsListenPort
            // 
            butAddRightsListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            butAddRightsListenPort.Location = new System.Drawing.Point(4, 3);
            butAddRightsListenPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butAddRightsListenPort.Name = "butAddRightsListenPort";
            butAddRightsListenPort.Size = new System.Drawing.Size(221, 52);
            butAddRightsListenPort.TabIndex = 2;
            butAddRightsListenPort.Tag = "Add rights to listen on port {0}";
            butAddRightsListenPort.Text = "Add rights to listen on port {0}";
            butAddRightsListenPort.UseVisualStyleBackColor = true;
            butAddRightsListenPort.Click += butListenPort_Click;
            // 
            // butRemoveRightsListenPort
            // 
            butRemoveRightsListenPort.Dock = System.Windows.Forms.DockStyle.Fill;
            butRemoveRightsListenPort.Location = new System.Drawing.Point(233, 3);
            butRemoveRightsListenPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butRemoveRightsListenPort.Name = "butRemoveRightsListenPort";
            butRemoveRightsListenPort.Size = new System.Drawing.Size(222, 52);
            butRemoveRightsListenPort.TabIndex = 3;
            butRemoveRightsListenPort.Tag = "Remove rights to listen on port {0}";
            butRemoveRightsListenPort.Text = "Remove rights to listen on port {0}";
            butRemoveRightsListenPort.UseVisualStyleBackColor = true;
            butRemoveRightsListenPort.Click += butRemoveListenPort_Click;
            // 
            // tplFirewall
            // 
            tplFirewall.ColumnCount = 2;
            tplFirewall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplFirewall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplFirewall.Controls.Add(butAddFirewall, 0, 0);
            tplFirewall.Controls.Add(butRemoveFirewall, 1, 0);
            tplFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            tplFirewall.Location = new System.Drawing.Point(0, 272);
            tplFirewall.Margin = new System.Windows.Forms.Padding(0);
            tplFirewall.Name = "tplFirewall";
            tplFirewall.RowCount = 1;
            tplFirewall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplFirewall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplFirewall.Size = new System.Drawing.Size(459, 58);
            tplFirewall.TabIndex = 6;
            // 
            // butAddFirewall
            // 
            butAddFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            butAddFirewall.Location = new System.Drawing.Point(4, 3);
            butAddFirewall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butAddFirewall.Name = "butAddFirewall";
            butAddFirewall.Size = new System.Drawing.Size(221, 52);
            butAddFirewall.TabIndex = 3;
            butAddFirewall.Tag = "Open port {0} in firewall";
            butAddFirewall.Text = "Open port {0} in firewall";
            butAddFirewall.UseVisualStyleBackColor = true;
            butAddFirewall.Click += butAddFirewall_Click;
            // 
            // butRemoveFirewall
            // 
            butRemoveFirewall.Dock = System.Windows.Forms.DockStyle.Fill;
            butRemoveFirewall.Location = new System.Drawing.Point(233, 3);
            butRemoveFirewall.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butRemoveFirewall.Name = "butRemoveFirewall";
            butRemoveFirewall.Size = new System.Drawing.Size(222, 52);
            butRemoveFirewall.TabIndex = 4;
            butRemoveFirewall.Text = "Remove firewall rules";
            butRemoveFirewall.UseVisualStyleBackColor = true;
            butRemoveFirewall.Click += butRemoveFirewall_Click;
            // 
            // tplStartWithWindows
            // 
            tplStartWithWindows.ColumnCount = 2;
            tplStartWithWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplStartWithWindows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplStartWithWindows.Controls.Add(butEnableStartWithWindows, 0, 0);
            tplStartWithWindows.Controls.Add(butDisableStartWithWindows, 1, 0);
            tplStartWithWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            tplStartWithWindows.Location = new System.Drawing.Point(0, 330);
            tplStartWithWindows.Margin = new System.Windows.Forms.Padding(0);
            tplStartWithWindows.Name = "tplStartWithWindows";
            tplStartWithWindows.RowCount = 1;
            tplStartWithWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplStartWithWindows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tplStartWithWindows.Size = new System.Drawing.Size(459, 55);
            tplStartWithWindows.TabIndex = 7;
            // 
            // butEnableStartWithWindows
            // 
            butEnableStartWithWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            butEnableStartWithWindows.Location = new System.Drawing.Point(4, 3);
            butEnableStartWithWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butEnableStartWithWindows.Name = "butEnableStartWithWindows";
            butEnableStartWithWindows.Size = new System.Drawing.Size(221, 49);
            butEnableStartWithWindows.TabIndex = 3;
            butEnableStartWithWindows.Text = "Start with Windows";
            butEnableStartWithWindows.UseVisualStyleBackColor = true;
            butEnableStartWithWindows.Click += butEnableStartWithWindows_Click;
            // 
            // butDisableStartWithWindows
            // 
            butDisableStartWithWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            butDisableStartWithWindows.Location = new System.Drawing.Point(233, 3);
            butDisableStartWithWindows.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            butDisableStartWithWindows.Name = "butDisableStartWithWindows";
            butDisableStartWithWindows.Size = new System.Drawing.Size(222, 49);
            butDisableStartWithWindows.TabIndex = 4;
            butDisableStartWithWindows.Text = "Does not start with Windows";
            butDisableStartWithWindows.UseVisualStyleBackColor = true;
            butDisableStartWithWindows.Click += butDisableStartWithWindows_Click;
            // 
            // toolTipPort
            // 
            toolTipPort.ShowAlways = true;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 397);
            Controls.Add(tlpGlobal);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FrmSettings";
            Padding = new System.Windows.Forms.Padding(6);
            Text = "Gameserver Control Set Computer Settings";
            tlpGlobal.ResumeLayout(false);
            tlpGlobal.PerformLayout();
            tlpListenPort.ResumeLayout(false);
            tplFirewall.ResumeLayout(false);
            tplStartWithWindows.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGlobal;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.TableLayoutPanel tlpListenPort;
        private System.Windows.Forms.Button butAddRightsListenPort;
        private System.Windows.Forms.Button butRemoveRightsListenPort;
        private System.Windows.Forms.TableLayoutPanel tplFirewall;
        private System.Windows.Forms.Button butAddFirewall;
        private System.Windows.Forms.Button butRemoveFirewall;
        private System.Windows.Forms.TableLayoutPanel tplStartWithWindows;
        private System.Windows.Forms.Button butEnableStartWithWindows;
        private System.Windows.Forms.Button butDisableStartWithWindows;
        private System.Windows.Forms.ToolTip toolTipPort;
    }
}

