using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PassRegistration.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using PassRegistration.Models;
    public class PassRegistrationController : Controller
    {
        private ApplicationDbContext _dbContext;

        public PassRegistrationController()
        {
            _dbContext = new ApplicationDbContext();
        }

        // GET: Videos
        public ActionResult Index()
        {
            var registrations = _dbContext.PassRegistrations.ToList();

            return View(registrations);
        }
    }
}