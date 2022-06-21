using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeLSS
{
   public class AccountModel
   {
        private OnlineShopDBCounttext counttext = null;
       public AccountModel()
        {
            counttext = new OnlineShopDBCounttext();
        }
        public bool Login(string userName,string password)
        {
            object[]=new[]
            {
                new SqlPa
            }
            var res = counttext.Database.SqlQuery<bool>("sp_Account_Login @UserName,@Password");
        }
   }
}
