using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SOLIDApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Demo presenting Object Oriented Design principles and popular Design Patterns.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details:";

            return View();
        }
        public ActionResult OOD()
        {
            return View();
        }
    }
}