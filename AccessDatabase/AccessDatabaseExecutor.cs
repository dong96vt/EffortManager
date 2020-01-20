using System;
using System.Data;
using System.Data.SqlClient;

namespace EffortManager.AccessDatabase
{
    public class AccessDatabaseExecutor : IDisposable
    {
        readonly SqlConnection sqlConnection;
        public AccessDatabaseExecutor(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }

        public DataSet SelectExecute(string tableName, string query)
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

        public bool QueryExecute(string query)
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