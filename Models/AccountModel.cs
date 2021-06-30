using DatabaseProvider;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModel
    {
        private DataContext context = null;

        public AccountModel()
        {
            context = new DataContext();
        }
        public bool Login(string userName, string password)
        {
            return context.Accounts.Where(p => p.UserName == userName && p.Password == password).FirstOrDefault() != null;
        }
    }
}
