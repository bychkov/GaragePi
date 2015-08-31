using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GarageMvc5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
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