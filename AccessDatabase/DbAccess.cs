using System;
using System.Data;
using System.Data.SqlClient;

namespace EffortManager.AccessDatabase
{
    public class DbAccess : IDisposable
    {
        readonly SqlConnection sqlConnection;
        public DbAccess(){
            BaseConnection conn = new BaseConnection();
            conn.CreateConnection();
            sqlConnection = conn.sqlConnection;
        }
        public DbAccess(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        public DataSet ExecuteQuery(string tableName, string query)
        {
            DataSet data = new DataSet(tableName);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand(query, sqlConnection);
            SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapter);

            sqlConnection.Open();
            adapter.Fill(data);
            sqlConnection.Close();
            return data;
        }

        public bool ExecuteNonQuery(string query)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }

        public void Dispose()
        {
            if (sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
        }
    }
}