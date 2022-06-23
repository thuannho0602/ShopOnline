using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ShopONLINEDongHo.Models
{
    
    public class AccountModel
    {
        private OnlineShopBdContext context = null;
        public AccountModel()
        {
            context = new OnlineShopBdContext();
        }
        public bool Longin(string userName, string password)
        {
            object[] sqlParams =
            {
                new SqlParameter("@UserName",userName),
                new SqlParameter("@Password", password),

            };
            var res = context.Database.SqlQuery<bool>("sp_Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }
}