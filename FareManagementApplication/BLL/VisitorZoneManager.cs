using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagementApplication.DAL;
using FareManagementApplication.Model;

namespace FareManagementApplication.BLL
{
    class VisitorZoneManager
    {
        VisitorZoneGateway visitorZoneGateway=new VisitorZoneGateway();
        public bool SaveVisitorZone(VisitorZone visitorZone)
        {
            return visitorZoneGateway.SaveVisitorZone(visitorZone);
        }

        public List<VisitorZone> GetVisitorZoneByZoneId(int zoneId)
        {
            return visitorZoneGateway.GetVisitorZoneByZoneId(zoneId);
        }
    }
}
