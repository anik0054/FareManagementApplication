namespace FareManagementApplication.UI
{
    partial class ZoneSpecificVisitorInformationForm
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
            this.showButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectZoneComboBox = new System.Windows.Forms.ComboBox();
            this.zoneSpecificVisitorInformationListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.exportToExcelButton = new System.Windows.Forms.Button();
            this.saveExcelFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(423, 29);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 5;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Zone";
            // 
            // selectZoneComboBox
            // 
            this.selectZoneComboBox.FormattingEnabled = true;
            this.selectZoneComboBox.Location = new System.Drawing.Point(160, 31);
            this.selectZoneComboBox.Name = "selectZoneComboBox";
            this.selectZoneComboBox.Size = new System.Drawing.Size(243, 21);
            this.selectZoneComboBox.TabIndex = 6;
            // 
            // zoneSpecificVisitorInformationListView
            // 
            this.zoneSpecificVisitorInformationListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.zoneSpecificVisitorInformationListView.Location = new System.Drawing.Point(41, 71);
            this.zoneSpecificVisitorInformationListView.Name = "zoneSpecificVisitorInformationListView";
            this.zoneSpecificVisitorInformationListView.Size = new System.Drawing.Size(520, 212);
            this.zoneSpecificVisitorInformationListView.TabIndex = 7;
            this.zoneSpecificVisitorInformationListView.UseCompatibleStateImageBehavior = false;
            this.zoneSpecificVisitorInformationListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact Number";
            this.columnHeader3.Width = 236;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(461, 302);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // exportToExcelButton
            // 
            this.exportToExcelButton.Location = new System.Drawing.Point(398, 344);
            this.exportToExcelButton.Name = "exportToExcelButton";
            this.exportToExcelButton.Size = new System.Drawing.Size(163, 23);
            this.exportToExcelButton.TabIndex = 10;
            this.exportToExcelButton.Text = "Export To Excel";
            this.exportToExcelButton.UseVisualStyleBackColor = true;
            this.exportToExcelButton.Click += new System.EventHandler(this.exportToExcelButton_Click);
            // 
            // saveExcelFileDialog
            // 
            this.saveExcelFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveExcelFileDialog_FileOk);
            // 
            // ZoneSpecificVisitorInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 379);
            this.Controls.Add(this.exportToExcelButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zoneSpecificVisitorInformationListView);
            this.Controls.Add(this.selectZoneComboBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.label1);
            this.Name = "ZoneSpecificVisitorInformationForm";
            this.Text = "Zone Specific Visitor Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectZoneComboBox;
        private System.Windows.Forms.ListView zoneSpecificVisitorInformationListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button exportToExcelButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SaveFileDialog saveExcelFileDialog;
    }
}