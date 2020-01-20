using System.Data;
using System.Data.SqlClient;
namespace EffortManager.AccessDatabase
{
    public class BaseConnection
    {
        string connectionString;
        string serverName;
        string databaseName;
        string username;
        string password;
        SqlConnection sqlConnection;

        public BaseConnection()
        {
            connectionString = @"Data Source=.;Initial Catalog=EffortManager;Trusted_Connection=True;";
        }
        public void CreateConnection(){
            sqlConnection = new SqlConnection(connectionString);
        }
    }
}