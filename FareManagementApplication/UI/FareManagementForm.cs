using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FareManagementApplication.UI;

namespace FareManagementApplication
{
    public partial class FareManagementForm : Form
    {
        public FareManagementForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeEntryForm zoneTypeEntryForm=new ZoneTypeEntryForm();
            zoneTypeEntryForm.Show();
        }

        private void visitorEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryForm visitorEntryForm=new VisitorEntryForm();
            visitorEntryForm.Show();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorInformationForm zoneSpecificVisitorInformationForm=new ZoneSpecificVisitorInformationForm();
            zoneSpecificVisitorInformationForm.Show();
        }

        private void zoneWiseVisitorNummberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberForm zoneWiseVisitorNumberForm=new ZoneWiseVisitorNumberForm();
            zoneWiseVisitorNumberForm.Show();
        }
    }
}
