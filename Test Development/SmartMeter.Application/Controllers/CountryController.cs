using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer.Models;
using BusinessLayer.DAL;

namespace SmartMeter.Application.Controllers
{
    public class CountryController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        //
        // GET: /Country/

        public ActionResult Index()
        {
            var courses = unitOfWork.CountryRepository.Get();
            return View(courses.ToList());

            //return View(db.Countries.ToList());
        }

        //
        // GET: /Country/Details/5

        public ActionResult Details(int id = 0)
        {
            Country country = unitOfWork.CountryRepository.GetByID(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        //
        // GET: /Country/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Country/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.CountryRepository.Insert(country);
                    unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }

            return View(country);
        }

        //
        // GET: /Country/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Country country = unitOfWork.CountryRepository.GetByID(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        //
        // POST: /Country/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Country country)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    unitOfWork.CountryRepository.Update(country);
                    unitOfWork.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                //Log the error (add a variable name after DataException)
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
            }
            return View(country);
        }

        //
        // GET: /Country/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Country country = unitOfWork.CountryRepository.GetByID(id);
            if (country == null)
            {
                return HttpNotFound();
            }
            return View(country);
        }

        //
        // POST: /Country/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Country country = unitOfWork.CountryRepository.GetByID(id);
            unitOfWork.CountryRepository.Delete(id);
            unitOfWork.Save();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            unitOfWork.Dispose();
            base.Dispose(disposing);
        }
    }
}