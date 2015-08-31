using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Garage.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult Camera()
        {
            return View();
        }

        public ActionResult Door()
        {
            System.Diagnostics.Process.Start("/home/pi/Desktop/Scripts/relay.sh");
            return View("Index");
        }
    }
}
