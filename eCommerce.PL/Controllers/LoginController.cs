using eCommerce.BLL.Concrete;
using eCommerce.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eCommerce.PL.Controllers
{
    public class LoginController : Controller
    {
        private UserController _userController;

        public LoginController()
        {
            _userController = new UserController();
        }

        public ActionResult Login(LoginViewModel model)
        {
            User user = _userController.Login(model.Username, model.Password);

            if (user != null)
            {
                Session["AdminUser"] = user;
                return RedirectToAction("AdminPage", "Admin");

            }
            else
            {
                return View();
            }
        }


        public ActionResult GiveAnError()
        {
            return View();
        }
    }
}