using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FareManagementApplication.Model
{
    public class VisitorZone
    {
        public int VisitorId { get; set; }
        public string VisitorName { get; set; }
        public string VisitorEmail { get; set; }
        public string VisitorContactNumber { get; set; }
        public int ZoneId { get; set; }
        public string ZoneName { get; set; }
    }
}
