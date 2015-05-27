using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FareManagementApplication.BLL;
using FareManagementApplication.Model;

namespace FareManagementApplication.UI
{
    public partial class ZoneTypeEntryForm : Form
    {
        ZoneManager zoneManager=new ZoneManager();
        public ZoneTypeEntryForm()
        {
            InitializeComponent();
            LoadZoneType();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Zone zone=new Zone();
            zone.Name = typeNameTextBox.Text;
            if (zone.Name == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else
            {
                if (zoneManager.SaveZoneType(zone))
                {
                    LoadZoneType();
                    MessageBox.Show("Zone Type has been successfully added");
                }
                else
                {
                    Close();
                    MessageBox.Show("An error occured");
                }
            }  
        }

        void LoadZoneType()
        {
            List<Zone> zoneList=zoneManager.GetAllZoneType();
            zoneTypeListView.Items.Clear();
            foreach (var index in zoneList)
            {
                ListViewItem listViewItem = new ListViewItem(index.Name);
                zoneTypeListView.Items.Add(listViewItem);
            }
        }
    }
}
