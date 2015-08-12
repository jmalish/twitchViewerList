namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblViewCount = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.lstViewerList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewerIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMGlobalModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblViewCount
            // 
            this.lblViewCount.AutoSize = true;
            this.lblViewCount.Location = new System.Drawing.Point(12, 24);
            this.lblViewCount.Name = "lblViewCount";
            this.lblViewCount.Size = new System.Drawing.Size(56, 13);
            this.lblViewCount.TabIndex = 0;
            this.lblViewCount.Text = "Viewers: 0";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(98, 24);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(52, 13);
            this.lblChannel.TabIndex = 0;
            this.lblChannel.Text = "Channel: ";
            // 
            // lstViewerList
            // 
            this.lstViewerList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstViewerList.FormattingEnabled = true;
            this.lstViewerList.Location = new System.Drawing.Point(12, 40);
            this.lstViewerList.Name = "lstViewerList";
            this.lstViewerList.Size = new System.Drawing.Size(217, 316);
            this.lstViewerList.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(241, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeChannelToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeChannelToolStripMenuItem
            // 
            this.changeChannelToolStripMenuItem.Name = "changeChannelToolStripMenuItem";
            this.changeChannelToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.changeChannelToolStripMenuItem.Text = "Change Channel";
            this.changeChannelToolStripMenuItem.Click += new System.EventHandler(this.changeChannelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewerIconsToolStripMenuItem,
            this.sStaffToolStripMenuItem,
            this.aAdminToolStripMenuItem,
            this.gMGlobalModsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.helpToolStripMenuItem.Text = "Icon Dictionary";
            // 
            // viewerIconsToolStripMenuItem
            // 
            this.viewerIconsToolStripMenuItem.Name = "viewerIconsToolStripMenuItem";
            this.viewerIconsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.viewerIconsToolStripMenuItem.Text = "@ - Moderators";
            // 
            // sStaffToolStripMenuItem
            // 
            this.sStaffToolStripMenuItem.Name = "sStaffToolStripMenuItem";
            this.sStaffToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sStaffToolStripMenuItem.Text = "S_ - Staff";
            // 
            // aAdminToolStripMenuItem
            // 
            this.aAdminToolStripMenuItem.Name = "aAdminToolStripMenuItem";
            this.aAdminToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aAdminToolStripMenuItem.Text = "A_ - Admin";
            // 
            // gMGlobalModsToolStripMenuItem
            // 
            this.gMGlobalModsToolStripMenuItem.Name = "gMGlobalModsToolStripMenuItem";
            this.gMGlobalModsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gMGlobalModsToolStripMenuItem.Text = "GM_ - Global Mods";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 365);
            this.Controls.Add(this.lstViewerList);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lblViewCount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Twitch Viewer List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblViewCount;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.ListBox lstViewerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewerIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gMGlobalModsToolStripMenuItem;
    }
}

