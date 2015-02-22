namespace skbtInstaller
{
    partial class frmMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnInstall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewServer = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblDetails = new System.Windows.Forms.Label();
            this.cBoxArmaPath = new System.Windows.Forms.ComboBox();
            this.fBrowserAddPath = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProviderMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdFindFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdNewConfig = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInstall
            // 
            this.btnInstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstall.ForeColor = System.Drawing.Color.Green;
            this.btnInstall.Location = new System.Drawing.Point(10, 112);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(147, 41);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "INSTALL";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select your arma installation folder";
            // 
            // btnNewServer
            // 
            this.btnNewServer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNewServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewServer.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNewServer.Location = new System.Drawing.Point(413, 26);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(50, 25);
            this.btnNewServer.TabIndex = 3;
            this.btnNewServer.Text = "New";
            this.btnNewServer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUninstall.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUninstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUninstall.Location = new System.Drawing.Point(163, 112);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(147, 41);
            this.btnUninstall.TabIndex = 4;
            this.btnUninstall.Text = "UNINSTALL";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.Teal;
            this.btnConfig.Location = new System.Drawing.Point(316, 112);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(147, 41);
            this.btnConfig.TabIndex = 5;
            this.btnConfig.Text = "CONFIGURE";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // lblDetails
            // 
            this.lblDetails.ForeColor = System.Drawing.Color.DimGray;
            this.lblDetails.Location = new System.Drawing.Point(13, 51);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(450, 58);
            this.lblDetails.TabIndex = 6;
            this.lblDetails.Text = "Waiting for user action...";
            // 
            // cBoxArmaPath
            // 
            this.cBoxArmaPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cBoxArmaPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.cBoxArmaPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxArmaPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxArmaPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxArmaPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cBoxArmaPath.FormattingEnabled = true;
            this.cBoxArmaPath.Location = new System.Drawing.Point(10, 26);
            this.cBoxArmaPath.Name = "cBoxArmaPath";
            this.cBoxArmaPath.Size = new System.Drawing.Size(397, 24);
            this.cBoxArmaPath.TabIndex = 7;
            this.cBoxArmaPath.SelectedIndexChanged += new System.EventHandler(this.cBoxArmaPath_SelectedIndexChanged);
            // 
            // errorProviderMain
            // 
            this.errorProviderMain.ContainerControl = this;
            // 
            // ofdFindFile
            // 
            this.ofdFindFile.FileName = "*.exe";
            this.ofdFindFile.Tag = "Arma Server EXE";
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(472, 162);
            this.Controls.Add(this.cBoxArmaPath);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnUninstall);
            this.Controls.Add(this.btnNewServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInstall);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 200);
            this.MinimumSize = new System.Drawing.Size(488, 200);
            this.Name = "frmMainWindow";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SKBT Installer for Windows";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.ComboBox cBoxArmaPath;
        private System.Windows.Forms.FolderBrowserDialog fBrowserAddPath;
        private System.Windows.Forms.ErrorProvider errorProviderMain;
        private System.Windows.Forms.OpenFileDialog ofdFindFile;
        private System.Windows.Forms.SaveFileDialog sfdNewConfig;
    }
}

