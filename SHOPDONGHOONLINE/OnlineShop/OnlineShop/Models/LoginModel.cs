using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class LoginModel
    {
        [Reducer]
        public string UserName { set; get; }
        public string Password { set; get; }
        public string RememberMe { set; get; }
    }
}