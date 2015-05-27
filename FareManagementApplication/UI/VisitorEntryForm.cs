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
    public partial class VisitorEntryForm : Form
    {   
        ZoneManager zoneManager=new ZoneManager();
        VisitorManager visitorManager=new VisitorManager();
        VisitorZoneManager visitorZoneManager=new VisitorZoneManager();
        public VisitorEntryForm()
        {
            InitializeComponent();
            LoadZoneType();
        }

        private void LoadZoneType()
        {
            List<Zone> zoneList=zoneManager.GetAllZoneType();
            zoneTypeCheckedListBox.DataSource = null;
            zoneTypeCheckedListBox.DataSource = zoneList;
            zoneTypeCheckedListBox.ValueMember = "Id";
            zoneTypeCheckedListBox.DisplayMember = "Name";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Visitor visitor=new Visitor();
            visitor.Name = NameTextBox.Text;
            visitor.Email = emailTextBox.Text;
            visitor.ContactNumber = contactNumberTextBox.Text;
            if (visitor.Name == "" || visitor.Email == "" || visitor.ContactNumber == "" || zoneTypeCheckedListBox.CheckedItems.Count<1)
            {
                MessageBox.Show("Name, Email or Contact Number cannot be empty and\n" +
                                "You must select at least one zone");
            }
            else
            {
                int id=visitorManager.SaveVisitor(visitor);
                if (id > 0)
                {
                    foreach (var index in zoneTypeCheckedListBox.CheckedItems)
                    {
                        Zone zone = (Zone) index;
                        VisitorZone visitorZone = new VisitorZone();
                        visitorZone.VisitorId = id;
                        visitorZone.ZoneId = zone.Id;
                        visitorZoneManager.SaveVisitorZone(visitorZone);
                    }
                    MessageBox.Show("A visitor has been successfully added");
                }
                else
                {
                    MessageBox.Show("An error occured");
                }
            }
        }
    }
}
