using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace donghothoitrangOnline1.Areas.Admon.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admon/Home
        public ActionResult Index()
        {
            return View("Index", "Login");
            //return RedirectToAction("Index", "Login");
        }
    }
}