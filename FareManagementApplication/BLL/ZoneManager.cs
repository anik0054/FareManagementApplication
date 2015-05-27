using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagementApplication.DAL;
using FareManagementApplication.Model;

namespace FareManagementApplication.BLL
{
    class ZoneManager
    {
        ZoneGateway zoneGateway=new ZoneGateway();

        public bool SaveZoneType(Zone zone)
        {
            return zoneGateway.SaveZoneType(zone);
        }

        public List<Zone> GetAllZoneType()
        {
            return zoneGateway.GetAllZoneType();
        }
    }
}
