using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        public ActionResult EducationList()
        {
            var values = db.TblEducation.ToList(); // to list = Select * from
            return View(values);     //return view gözükürken değeleri de beraberinde getirsin
        }

        [HttpGet]   //sayfa yüklendiğinde
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]   //sayfa yüklendiğinde
        public ActionResult CreateEducation(TblEducation category)
        {
            db.TblEducation.Add(category);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        //silme işlemi için bir attribute gerekmiyor sadece id'yi alıp silmek yeterli
        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View("UpdateEducation", value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation edu)
        {
            var value = db.TblEducation.Find(edu.EducationId);
            value.Title = edu.Title;
            value.Description = edu.Description;
            value.SubTitle = edu.SubTitle;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}