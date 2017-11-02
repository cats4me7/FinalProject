using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassRegistration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Information about the company and the Passes.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Buisness Contacts.";

            return View();
        }

        public ActionResult AdminPass()
        {
            ViewBag.Message = "Admin Pass Repository.";

            return View();
        }
    }
}