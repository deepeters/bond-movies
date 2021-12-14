using BondMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BondMovies.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public string Login(UserModel userModel)
        {
            return "Results: Username = " + userModel.Username + "PW = " + userModel.Password;
        }

    }
}