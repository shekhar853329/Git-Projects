using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Initial.Models;

namespace MVC_Initial.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var e = GetEmployee();
            return View(e);
        }
        private Employee GetEmployee()
        {
            return new Employee
            {
                Id = 1,
                Name = "shekhar",
                Address = "noida"
            };
        }
    }
}