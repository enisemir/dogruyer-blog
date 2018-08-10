using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User_Out.Models;

namespace User_Out.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {

            return View();
        }
        [HttpPost]
        public ViewResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                return View("Index", user);
            }
            else
            {
                return View();
            }           
        }
        public ViewResult Register()
        {
            return View();
        }
    }
}