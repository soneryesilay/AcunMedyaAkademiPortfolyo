using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();

        public PartialViewResult PartialContacts()
        {
            var values = db.TblContacts.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestionial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProject()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialCategories()
        {
            var values = db.TblCategory.ToList();
            return PartialView(values);

        }

        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
           var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public PartialViewResult PartialStatistic()
        {
            var values = db.TblStatistic.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialEducation()
        {
            var values =  db.TblEducation.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }    
        
        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeroSection()
        {
            var values = db.TblSocialMedia.ToList();
            return PartialView(values);
        }
    }
}