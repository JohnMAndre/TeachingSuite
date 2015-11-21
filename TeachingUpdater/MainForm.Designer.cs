namespace TeachingUpdater
{
    partial class B
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(B));
            this.bgwCheckForUpdate = new System.ComponentModel.BackgroundWorker();
            this.bgwDownloadUpdate = new System.ComponentModel.BackgroundWorker();
            this.bgwInstallUpdate = new System.ComponentModel.BackgroundWorker();
            this.KryptonManager = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.KryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.KryptonPanel = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.llblVersionsOnWebsite = new System.Windows.Forms.LinkLabel();
            this.btnDownload = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnInstall = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.kryptonPalette2 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.KryptonPanel)).BeginInit();
            this.KryptonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgwCheckForUpdate
            // 
            this.bgwCheckForUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckForUpdate_DoWork);
            this.bgwCheckForUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheckForUpdate_RunWorkerCompleted);
            // 
            // KryptonManager
            // 
            this.KryptonManager.GlobalPalette = this.kryptonPalette2;
            this.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // KryptonPalette1
            // 
            this.KryptonPalette1.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // KryptonPanel
            // 
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
            this.KryptonPanel.Size = new System.Drawing.Size(610, 227);
            this.KryptonPanel.TabIndex = 52;
            // 
            // llblVersionsOnWebsite
            // 
            this.llblVersionsOnWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblVersionsOnWebsite.AutoSize = true;
            this.llblVersionsOnWebsite.BackColor = System.Drawing.Color.Transparent;
            this.llblVersionsOnWebsite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblVersionsOnWebsite.Location = new System.Drawing.Point(12, 195);
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
            this.btnDownload.Location = new System.Drawing.Point(178, 188);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(114, 29);
            this.btnDownload.TabIndex = 62;
            this.btnDownload.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnDownload.Values.Text = "&Download";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(481, 188);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 29);
            this.btnClose.TabIndex = 61;
            this.btnClose.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnClose.Values.Text = "&Close";
            // 
            // btnInstall
            // 
            this.btnInstall.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnInstall.Enabled = false;
            this.btnInstall.Location = new System.Drawing.Point(309, 188);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(114, 29);
            this.btnInstall.TabIndex = 60;
            this.btnInstall.Values.ImageTransparentColor = System.Drawing.Color.White;
            this.btnInstall.Values.Text = "&Install";
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
            this.txtStatus.Size = new System.Drawing.Size(583, 119);
            this.txtStatus.TabIndex = 0;
            // 
            // kryptonPalette2
            // 
            this.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.kryptonPalette2;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 227);
            this.Controls.Add(this.KryptonPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "B";
            this.Text = "Updating Teaching App";
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
        internal ComponentFactory.Krypton.Toolkit.KryptonPalette KryptonPalette1;
        internal ComponentFactory.Krypton.Toolkit.KryptonPanel KryptonPanel;
        internal System.Windows.Forms.LinkLabel llblVersionsOnWebsite;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnDownload;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnClose;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton btnInstall;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtStatus;
        internal System.Windows.Forms.Timer Timer1;
        internal ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}

