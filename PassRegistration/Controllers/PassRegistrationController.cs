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

        public ActionResult AdminPass1()
        {
            var registrations = _dbContext.PassRegistrations.ToList();

            return View(registrations);
        }

        public ActionResult New()
        {
            return View();
        }

        public ActionResult Add(PassRegistration registration)
        {
            _dbContext.PassRegistrations.Add(registration);
            _dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Delete(int id)
        {
            var registration = _dbContext.PassRegistrations.SingleOrDefault(v => v.Id == id);

            if (registration == null)
                return HttpNotFound();

            return View(registration);
        }

        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var registration = _dbContext.PassRegistrations.SingleOrDefault(v => v.Id == id);
            if (registration == null)
                return HttpNotFound();
            _dbContext.PassRegistrations.Remove(registration);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int id)
        {
            var video = _dbContext.PassRegistrations.SingleOrDefault(v => v.Id == id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }

        public ActionResult Update(PassRegistration video)
        {
            var videoInDb = _dbContext.PassRegistrations.SingleOrDefault(v => v.Id == video.Id);

            if (videoInDb == null)
                return HttpNotFound();

            videoInDb.Name = video.Name;
            videoInDb.NumberInHouse = video.NumberInHouse;
            videoInDb.Address = video.Address;
            videoInDb.City = video.City;
            videoInDb.PhoneNumber = video.PhoneNumber;
            videoInDb.Email = video.Email;
            videoInDb.Status = video.Status;
            _dbContext.SaveChanges();

            return RedirectToAction("AdminPass1");
        }
    }
}