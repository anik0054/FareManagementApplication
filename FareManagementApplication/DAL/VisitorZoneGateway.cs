using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FareManagementApplication.Model;

namespace FareManagementApplication.DAL
{
    class VisitorZoneGateway
    {
        public bool SaveVisitorZone(VisitorZone visitorZone)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FareConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO VisitorZoneTable (VisitorId,ZoneId) VALUES('" + visitorZone.VisitorId +"','" + visitorZone.ZoneId+ "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int row = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (row == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<VisitorZone> GetVisitorZoneByZoneId(int zoneId)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FareConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM VisitorZone WHERE ZoneId='"+zoneId+"'";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<VisitorZone> visitorZoneList = new List<VisitorZone>();
            while (sqlDataReader.Read())
            {
                VisitorZone visitorZone = new VisitorZone();
                visitorZone.VisitorId = int.Parse(sqlDataReader["VisitorId"].ToString());
                visitorZone.VisitorName = sqlDataReader["VisitorName"].ToString();
                visitorZone.VisitorEmail = sqlDataReader["VisitorEmail"].ToString();
                visitorZone.VisitorContactNumber = sqlDataReader["VisitorContactNumber"].ToString();
                visitorZone.ZoneId = int.Parse(sqlDataReader["ZoneId"].ToString());
                visitorZone.ZoneName = sqlDataReader["ZoneName"].ToString();
                visitorZoneList.Add(visitorZone);
            }
            return visitorZoneList;
        }
    }
}
