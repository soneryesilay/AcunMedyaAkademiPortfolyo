using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ExperienceController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        // GET: Experience
        public ActionResult ExperienceList()
        {
            var values = db.TblExperience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateExperience(TblExperience experience)
        {
            db.TblExperience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public ActionResult DeleteExperience(int id)
        {
            var value = db.TblExperience.Find(id);
            db.TblExperience.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ExperienceList");

        }

        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = db.TblExperience.Find(id);
            return View("UpdateExperience", value);
        }

        [HttpPost]  
        public ActionResult UpdateExperience(TblExperience experience)
        {
            var value = db.TblExperience.Find(experience.ExperienceId);
            value.Title = experience.Title;
            value.Description = experience.Description;
            value.Period = experience.Period;
            db.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

    }
}