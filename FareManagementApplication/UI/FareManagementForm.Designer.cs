namespace FareManagementApplication
{
    partial class FareManagementForm
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
            this.mainAreaMenuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneSpecificVisitorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoneWiseVisitorNummberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainAreaMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainAreaMenuStrip
            // 
            this.mainAreaMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.visitorToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.mainAreaMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainAreaMenuStrip.Name = "mainAreaMenuStrip";
            this.mainAreaMenuStrip.Size = new System.Drawing.Size(284, 24);
            this.mainAreaMenuStrip.TabIndex = 0;
            this.mainAreaMenuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // visitorToolStripMenuItem
            // 
            this.visitorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitorEntryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.visitorToolStripMenuItem.Name = "visitorToolStripMenuItem";
            this.visitorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.visitorToolStripMenuItem.Text = "Visitor";
            // 
            // visitorEntryToolStripMenuItem
            // 
            this.visitorEntryToolStripMenuItem.Name = "visitorEntryToolStripMenuItem";
            this.visitorEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.visitorEntryToolStripMenuItem.Text = "Visitor Entry";
            this.visitorEntryToolStripMenuItem.Click += new System.EventHandler(this.visitorEntryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneTypeToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // zoneTypeToolStripMenuItem
            // 
            this.zoneTypeToolStripMenuItem.Name = "zoneTypeToolStripMenuItem";
            this.zoneTypeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.zoneTypeToolStripMenuItem.Text = "Zone Type";
            this.zoneTypeToolStripMenuItem.Click += new System.EventHandler(this.zoneTypeToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoneSpecificVisitorDetailsToolStripMenuItem,
            this.zoneWiseVisitorNummberToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // zoneSpecificVisitorDetailsToolStripMenuItem
            // 
            this.zoneSpecificVisitorDetailsToolStripMenuItem.Name = "zoneSpecificVisitorDetailsToolStripMenuItem";
            this.zoneSpecificVisitorDetailsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.zoneSpecificVisitorDetailsToolStripMenuItem.Text = "Zone Specific Visitor Details";
            this.zoneSpecificVisitorDetailsToolStripMenuItem.Click += new System.EventHandler(this.zoneSpecificVisitorDetailsToolStripMenuItem_Click);
            // 
            // zoneWiseVisitorNummberToolStripMenuItem
            // 
            this.zoneWiseVisitorNummberToolStripMenuItem.Name = "zoneWiseVisitorNummberToolStripMenuItem";
            this.zoneWiseVisitorNummberToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.zoneWiseVisitorNummberToolStripMenuItem.Text = "Zone Wise Visitor Number";
            this.zoneWiseVisitorNummberToolStripMenuItem.Click += new System.EventHandler(this.zoneWiseVisitorNummberToolStripMenuItem_Click);
            // 
            // FareManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.mainAreaMenuStrip);
            this.MainMenuStrip = this.mainAreaMenuStrip;
            this.Name = "FareManagementForm";
            this.Text = "Main Area";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainAreaMenuStrip.ResumeLayout(false);
            this.mainAreaMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainAreaMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneSpecificVisitorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoneWiseVisitorNummberToolStripMenuItem;
    }
}

