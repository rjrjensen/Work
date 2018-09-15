using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VueProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult VueTutorial()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult JavaScriptTutorial()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}