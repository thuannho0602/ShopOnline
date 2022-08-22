using Models;
using OnlineShop.Code;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var reuult = new AccountModels().Login(model.UserName, model.Password);
            if(reuult&& ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { UserName=model.UserName});
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Tên Đăng Nhập Và Mật khẩu  Không Đúng");
            }
            return View(model);
        }
    }
}