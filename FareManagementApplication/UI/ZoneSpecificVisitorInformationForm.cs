using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FareManagementApplication.BLL;
using FareManagementApplication.Model;
using Microsoft.Office.Interop.Excel;

namespace FareManagementApplication.UI
{
    public partial class ZoneSpecificVisitorInformationForm : Form
    {
        ZoneManager zoneManager = new ZoneManager();
        VisitorZoneManager visitorZoneManager=new VisitorZoneManager();
        private string fieldFilename;
        public ZoneSpecificVisitorInformationForm()
        {
            InitializeComponent();
            LoadZoneType();
        }
        private void LoadZoneType()
        {
            List<Zone> zoneList = zoneManager.GetAllZoneType();
            selectZoneComboBox.DataSource = null;
            selectZoneComboBox.DataSource = zoneList;
            selectZoneComboBox.ValueMember = "Id";
            selectZoneComboBox.DisplayMember = "Name";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            zoneSpecificVisitorInformationListView.Items.Clear();
            totalTextBox.Clear();
            int zoneId = int.Parse(selectZoneComboBox.SelectedValue.ToString());
            List<VisitorZone> visitorZoneList=visitorZoneManager.GetVisitorZoneByZoneId(zoneId);
            int total = 0;
            foreach (var index in visitorZoneList)
            {
                ListViewItem listViewItem = new ListViewItem(index.VisitorName);
                listViewItem.SubItems.Add(index.VisitorEmail);
                listViewItem.SubItems.Add(index.VisitorContactNumber);
                zoneSpecificVisitorInformationListView.Items.Add(listViewItem);
                total++;
            }
            totalTextBox.Text = total.ToString();
        }

        private void exportToExcelButton_Click(object sender, EventArgs e)
        {
            saveExcelFileDialog.DefaultExt = "xlsx";
            saveExcelFileDialog.Filter = "Excel Files | *.xlsx";
            saveExcelFileDialog.ShowDialog();
            int zoneId = int.Parse(selectZoneComboBox.SelectedValue.ToString());
            string zoneName = selectZoneComboBox.Text;
            List<VisitorZone> visitorZoneList = visitorZoneManager.GetVisitorZoneByZoneId(zoneId);
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet workSheet = excel.ActiveSheet;
            workSheet.Cells[1, "A"] = zoneName;
            workSheet.Cells[2, "A"] = "";
            workSheet.Cells[3, "A"] = "Name";
            workSheet.Cells[3, "B"] = "Email";
            workSheet.Cells[3, "C"] = "Contact Number";
            int index1 = 4;
            foreach (var visitor in visitorZoneList)
            {
                for (int index2 = 1; index2 <= 3; index2++)
                {
                    workSheet.Cells[index1, "A"] = visitor.VisitorName;
                    workSheet.Cells[index1, "B"] = visitor.VisitorEmail;
                    workSheet.Cells[index1, "C"] = "\t" + visitor.VisitorContactNumber;
                }
                index1++;
            }
            workSheet.Columns.AutoFit();
            string fileName = fieldFilename;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            workSheet.SaveAs(fileName);
            MessageBox.Show("Data has been successfully exported to the Excel file");
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workSheet);
            excel = null;
            workSheet = null;
            GC.Collect();
        }

        private void saveExcelFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string filename = saveExcelFileDialog.FileName;
            fieldFilename = filename;
        }
    }
}
