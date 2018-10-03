using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class TempletedHTMLHelperController : Controller
    {
        // GET: TempletedHTMLHelper
        public ActionResult Index()
        {
            return View(emp);
        }
        private TempletedEmployee emp = new TempletedEmployee()
        {
            Id = 1,
            Name = "shekhar",
            Address = "noida",
            DOB = DateTime.Now
        };



    }
}