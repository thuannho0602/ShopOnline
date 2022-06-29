using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {SS
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            var reuult=new AccountModels()
        }
    }
}