using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_CanteenManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string userName, string password)
        {
            string query = "USER_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecQuery(query, new object[] { userName, password });
            return result.Rows.Count >0 ;
        }

       
    }
}
