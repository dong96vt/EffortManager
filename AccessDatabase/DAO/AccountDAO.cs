using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EffortManager.Models;

namespace EffortManager.AccessDatabase.DAO
{
    public class AccountDAO : BaseDAO<AccountDTO>
    {
        string tableName;
        public AccountDAO()
        {
            tableName = "Account";
        }

        public override bool Delete(string ID)
        {
            throw new System.NotImplementedException();
        }

        public override AccountDTO Get(string ID)
        {
            throw new System.NotImplementedException();
        }

        public override IEnumerable<AccountDTO> GetAll()
        {
            List<AccountDTO> accountDTOs = new List<AccountDTO>();
            string query = $@"SELECT * FROM {tableName}";
            DbAccess dbAccess = new DbAccess();
            var queryResults = dbAccess.ExecuteQuery(tableName, query);
            foreach (DataRow row in queryResults.Tables[0].Rows)
            {
                var accountDTO = new AccountDTO(){
                    ID = int.Parse(row["ID"].ToString()),
                    FullName = row["FullName"].ToString(),
                    Username =row["Username"].ToString(),
                    Password = row["Password"].ToString()
                };
                accountDTOs.Add(accountDTO);
            } 
            return accountDTOs;
        }

        public override bool Insert(AccountDTO obj)
        {
            throw new System.NotImplementedException();
        }

        public AccountDTO Login(string username, string password)
        {
            return GetAll().Where(u => u.Username.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
        }

        public override bool Update(AccountDTO obj)
        {
            throw new System.NotImplementedException();
        }
    }
}