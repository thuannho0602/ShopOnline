using Models.Framework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class AccountModels
    {
        private OnlineShopDbContext context = null;
        public AccountModels()
        {
            context = new OnlineShopDbContext();
        }
        public bool Login(string userNam, string password)
        {
            object[] sqlParams=
            {
                new SqlParameter(" @UserName",userNam),
                new SqlParameter("@Password",password);
            ;
            var res = context.Database.SqlQuery<bool>("sp_Account_Login @UserName,@Password", sqlParams).SingleOrDefault();
            return res;
        }
    }

}

