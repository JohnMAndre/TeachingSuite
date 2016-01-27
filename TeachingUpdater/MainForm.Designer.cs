namespace Teaching
{
    partial class UpdaterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterForm));
            this.bgwCheckForUpdate = new System.ComponentModel.BackgroundWorker();
            this.bgwDownloadUpdate = new System.ComponentModel.BackgroundWorker();
            this.bgwInstallUpdate = new System.ComponentModel.BackgroundWorker();
            this.KryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.KryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lblOverall = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.prgCurrentFile = new System.Windows.Forms.ProgressBar();
            this.prgOverall = new System.Windows.Forms.ProgressBar();
            this.llblVersionsOnWebsite = new System.Windows.Forms.LinkLabel();
            this.btnDownload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInstall = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrDownloadAsynch = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel)).BeginInit();
            this.KryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwCheckForUpdate
            // 
            this.bgwCheckForUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckForUpdate_DoWork);
            this.bgwCheckForUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheckForUpdate_RunWorkerCompleted);
            // 
            // bgwDownloadUpdate
            // 
            this.bgwDownloadUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwDownloadUpdate_DoWork);
            this.bgwDownloadUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwDownloadUpdate_RunWorkerCompleted);
            // 
            // bgwInstallUpdate
            // 
            this.bgwInstallUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwInstallUpdate_DoWork);
            this.bgwInstallUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwInstallUpdate_RunWorkerCompleted);
            // 
            // KryptonManager
            // 
            this.KryptonManager.GlobalPalette = this.kryptonPalette2;
            this.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // KryptonPanel
            // 
            this.KryptonPanel.Controls.Add(this.lblOverall);
            this.KryptonPanel.Controls.Add(this.lblCurrent);
            this.KryptonPanel.Controls.Add(this.prgCurrentFile);
            this.KryptonPanel.Controls.Add(this.prgOverall);
            this.KryptonPanel.Controls.Add(this.llblVersionsOnWebsite);
            this.KryptonPanel.Controls.Add(this.btnDownload);
            this.KryptonPanel.Controls.Add(this.btnClose);
            this.KryptonPanel.Controls.Add(this.btnInstall);
            this.KryptonPanel.Controls.Add(this.Label1);
            this.KryptonPanel.Controls.Add(this.txtStatus);
            this.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KryptonPanel.Location = new System.Drawing.Point(0, 0);
            this.KryptonPanel.Name = "KryptonPanel";
            this.KryptonPanel.Palette = this.kryptonPalette2;
            this.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.KryptonPanel.Size = new System.Drawing.Size(610, 339);
            this.KryptonPanel.TabIndex = 52;
            // 
            // lblOverall
            // 
            this.lblOverall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOverall.AutoSize = true;
            this.lblOverall.BackColor = System.Drawing.Color.Transparent;
            this.lblOverall.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverall.Location = new System.Drawing.Point(22, 272);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(51, 16);
            this.lblOverall.TabIndex = 64;
            this.lblOverall.Text = "Overall:";
            this.lblOverall.Visible = false;
            // 
            // lblCurrent
            // 
            this.lblCurrent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrent.AutoSize = true;
            this.lblCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrent.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrent.Location = new System.Drawing.Point(22, 242);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(54, 16);
            this.lblCurrent.TabIndex = 64;
            this.lblCurrent.Text = "Current:";
            this.lblCurrent.Visible = false;
            // 
            // prgCurrentFile
            // 
            this.prgCurrentFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgCurrentFile.Location = new System.Drawing.Point(82, 240);
            this.prgCurrentFile.Name = "prgCurrentFile";
            this.prgCurrentFile.Size = new System.Drawing.Size(519, 23);
            this.prgCurrentFile.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgCurrentFile.TabIndex = 63;
            this.prgCurrentFile.Visible = false;
            // 
            // prgOverall
            // 
            this.prgOverall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgOverall.Location = new System.Drawing.Point(82, 269);
            this.prgOverall.Name = "prgOverall";
            this.prgOverall.Size = new System.Drawing.Size(519, 23);
            this.prgOverall.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgOverall.TabIndex = 63;
            this.prgOverall.Visible = false;
            // 
            // llblVersionsOnWebsite
            // 
            this.llblVersionsOnWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblVersionsOnWebsite.AutoSize = true;
            this.llblVersionsOnWebsite.BackColor = System.Drawing.Color.Transparent;
            this.llblVersionsOnWebsite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblVersionsOnWebsite.Location = new System.Drawing.Point(15, 305);
            this.llblVersionsOnWebsite.Name = "llblVersionsOnWebsite";
            this.llblVersionsOnWebsite.Size = new System.Drawing.Size(152, 18);
            this.llblVersionsOnWebsite.TabIndex = 6;
            this.llblVersionsOnWebsite.TabStop = true;
            this.llblVersionsOnWebsite.Text = "View Version History";
            this.llblVersionsOnWebsite.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(181, 298);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(114, 29);
            this.btnDownload.TabIndex = 62;
            this.btnDownload.Values.Image = global::Teaching.Properties.Resources.download_16;
            this.btnDownload.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnDownload.Values.Text = "&Download";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(484, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 29);
            this.btnClose.TabIndex = 61;
            this.btnClose.Values.Image = global::Teaching.Properties.Resources.Erase_16;
            this.btnClose.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnClose.Values.Text = "&Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(312, 298);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(114, 29);
            this.btnInstall.TabIndex = 60;
            this.btnInstall.Values.Image = global::Teaching.Properties.Resources.checkmark_16;
            this.btnInstall.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnInstall.Values.Text = "&Install";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 16);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(15, 28);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatus.Size = new System.Drawing.Size(583, 206);
            this.txtStatus.TabIndex = 0;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // tmrDownloadAsynch
            // 
            this.tmrDownloadAsynch.Interval = 500;
            this.tmrDownloadAsynch.Tick += new System.EventHandler(this.tmrDownloadAsynch_Tick);
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 339);
            this.Controls.Add(this.KryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdaterForm";
            this.Text = "Updating Teaching App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdaterForm_FormClosing);
            this.Load += new System.EventHandler(this.B_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel)).EndInit();
            this.KryptonPanel.ResumeLayout(false);
            this.KryptonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgwCheckForUpdate;
        private System.ComponentModel.BackgroundWorker bgwDownloadUpdate;
        private System.ComponentModel.BackgroundWorker bgwInstallUpdate;
        internal ComponentFactory.Krypton.Toolkit.KryptonManager KryptonManager;
        internal ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette2;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel KryptonPanel;
        internal System.Windows.Forms.LinkLabel llblVersionsOnWebsite;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnDownload;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnInstall;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtStatus;
        internal System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ProgressBar prgOverall;
        internal System.Windows.Forms.Label lblOverall;
        internal System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.ProgressBar prgCurrentFile;
        internal System.Windows.Forms.Timer tmrDownloadAsynch;
    }
}

