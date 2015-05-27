namespace FareManagementApplication.UI
{
    partial class ZoneWiseVisitorNumberForm
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
            this.zoneSpecificVisitorInformationListView = new System.Windows.Forms.ListView();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // zoneSpecificVisitorInformationListView
            // 
            this.zoneSpecificVisitorInformationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneSpecificVisitorInformationListView.Location = new System.Drawing.Point(25, 27);
            this.zoneSpecificVisitorInformationListView.Name = "zoneSpecificVisitorInformationListView";
            this.zoneSpecificVisitorInformationListView.Size = new System.Drawing.Size(520, 212);
            this.zoneSpecificVisitorInformationListView.TabIndex = 8;
            this.zoneSpecificVisitorInformationListView.UseCompatibleStateImageBehavior = false;
            this.zoneSpecificVisitorInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(445, 260);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Total";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 321;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number of Visitors";
            this.columnHeader2.Width = 144;
            // 
            // ZoneWiseVisitorNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 298);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zoneSpecificVisitorInformationListView);
            this.Name = "ZoneWiseVisitorNumberForm";
            this.Text = "ZoneWiseVisitorNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneSpecificVisitorInformationListView;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}