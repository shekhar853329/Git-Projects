using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPractice.Controllers
{
    public class BuiltInHTMLHelperController : Controller
    {
        // GET: BuiltInHTMLHelper
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutUs(string name=null)
        {
            return View();
        }
    }
}