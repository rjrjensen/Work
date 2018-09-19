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
            return View();
        }

        public ActionResult JavaScriptTutorial()
        {
            return View();
        }

        public ActionResult Components()
        {
            return View();
        }

        public ActionResult Methods()
        {
            return View();
        }

        public ActionResult ControlFlow()
        {
            return View();
        }
    }
}