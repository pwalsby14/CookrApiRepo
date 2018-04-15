using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookrApi.Helpers
{
    public class DatabaseHelper
    {
        public static SqlConnection ConnectToDatabase()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "your_server.database.windows.net";
                builder.UserID = "your_user";
                builder.Password = "your_password";
                builder.InitialCatalog = "your_database";

                SqlConnection connection = new SqlConnection(builder.ConnectionString))
                
                return connection;
                
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
    }
}
