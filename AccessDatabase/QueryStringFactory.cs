using System.Collections.Generic;
using System.Text;

namespace EffortManager.AccessDatabase
{
    public class QueryStringFactory
    {
        public string GetSelectQueryString(string tableName,string conditions ,params string[] columns){
            StringBuilder columnsString = new StringBuilder();
            foreach(var column in columns){
                columnsString.Append($"{column},");
            }
            return $@"SELECT {columnsString.ToString().TrimEnd(',')} FROM {tableName} WHERE {conditions}";
        }
        public void GetInsertQueryString()
        {
            StringBuilder query = new StringBuilder();
            query.Append(@"INSERT INTO [dbo].[Account]
                                ([Username]
                                ,[Password]
                                ,[FullName]
                                ,[Email])
                            VALUES
                                (<Username, varchar(20),>
                                ,<Password, varchar(20),>
                                ,<FullName, nvarchar(200),>
                                ,<Email, varchar(200),>)");
        }
        public void GetUpdateQueryString()
        {
            StringBuilder query = new StringBuilder();
            query.Append(@"UPDATE [dbo].[Account]
                            SET [Username] = <Username, varchar(20),>
                                ,[Password] = <Password, varchar(20),>
                                ,[FullName] = <FullName, nvarchar(200),>
                                ,[Email] = <Email, varchar(200),>
                            WHERE <Search Conditions,,>");
        }
        public void GetDeleteQueryString()
        {
            StringBuilder query = new StringBuilder();
            query.Append(@"DELETE FROM [dbo].[Account]
                            WHERE <Search Conditions,,>");
        }
    }
}