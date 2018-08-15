using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using User_Out.Models;
using System.Net.Http;

namespace User_Out.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

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
                string[] username = Request.Form.GetValues("GirisYap");
                string[] pass = Request.Form.GetValues("Pass");
                string[] email = Request.Form.GetValues("Email");

                //for (int i = 0; i < keys.Length; i++)
                //{
                //    Response.Write(keys[i] + ": " + Request.Form[keys[i]] + "<br>");

                //}

                return View("View", user);
            }
            else
            {
                return View();
            }           
        }     
    }
}