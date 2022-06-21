using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace donghothoitrangOnline1.Areas.Admon.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admon/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult LoginAction()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}