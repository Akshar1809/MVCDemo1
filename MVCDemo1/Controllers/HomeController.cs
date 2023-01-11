using MVCDemo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVCDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Countries = new List<string> { 
                "India",
                "USA",
                "Canada",
                "Australia"
            };


            ViewData["City"] = new List<string> {
                "Ahmedabad",
                "CaliforniA",
                "Toronto",
                "Sydney"
            };
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}