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
    class ZoneGateway
    {
        public bool SaveZoneType(Zone zone)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FareConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO ZoneTable (Name) VALUES('" + zone.Name + "')";
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

        public List<Zone> GetAllZoneType()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FareConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "SELECT * FROM ZoneTable";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Zone> zoneList = new List<Zone>();
            while (sqlDataReader.Read())
            {
                Zone zone = new Zone();
                zone.Id = int.Parse(sqlDataReader["Id"].ToString());
                zone.Name = sqlDataReader["Name"].ToString();
                zoneList.Add(zone);
            }
            return zoneList;
        }
    }
}
