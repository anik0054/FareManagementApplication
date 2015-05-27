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
    public partial class ZoneWiseVisitorNumberForm : Form
    {
        ZoneManager zoneManager=new ZoneManager();
        public ZoneWiseVisitorNumberForm()
        {
            InitializeComponent();
            LoadListBox();
        }

        void LoadListBox()
        {
            zoneSpecificVisitorInformationListView.Items.Clear();
            List<Zone> zoneList=zoneManager.GetAllZoneType();
            int total = 0;
            foreach (var zone in zoneList)
            {
                VisitorZoneManager visitorZoneManager=new VisitorZoneManager();
                List<VisitorZone> visitorZoneList=visitorZoneManager.GetVisitorZoneByZoneId(zone.Id);
                int count = 0;
                foreach (var visitorZone in visitorZoneList)
                {
                    count++;
                }
                ListViewItem listViewItem = new ListViewItem(zone.Name);
                listViewItem.SubItems.Add(count.ToString());
                zoneSpecificVisitorInformationListView.Items.Add(listViewItem);
                total += count;
            }
            totalTextBox.Text = total.ToString();
        }
    }
}
