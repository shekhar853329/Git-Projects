using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCPractice.Models;

namespace MVCPractice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var emp1 = getemp();
            return View(emp1);
        }

        private Employee getemp()
        {
            return new Employee { Id = 1, name = "nitin" };
        }
    }
}