using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gamestation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A station for your games";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact info";

            return View();
        }
    }
}