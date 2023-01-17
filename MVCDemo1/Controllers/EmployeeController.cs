using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo1.Models;

namespace MVCDemo1.Controllers
{
   
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                EmployeeId= 1,
                Name="Patel",
                Gender="male",
                City="Vadodara"                
            };
            return View(emp);
        }
    }
}