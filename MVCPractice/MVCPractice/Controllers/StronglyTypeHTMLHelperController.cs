using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class StronglyTypeHTMLHelperController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            StronglyTypedEmployee emp = new StronglyTypedEmployee()
            {
                Name = "shekhar",
                Address = "noida",
                IsEmployee = true
            };
            return View(emp);
        }
        [HttpPost]
        public string Index1(string Name,string Address)
        {
            return Name;
        }
    }
}