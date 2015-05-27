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
    class VisitorGateway
    {
        public int SaveVisitor(Visitor visitor)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["FareConnectionString"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string query = "INSERT INTO VisitorTable (Name,Email,ContactNumber) OUTPUT INSERTED.ID VALUES('" + visitor.Name + "','" + visitor.Email + "','" + visitor.ContactNumber + "')";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            int id = (int)sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            return id;
        }
    }
}
