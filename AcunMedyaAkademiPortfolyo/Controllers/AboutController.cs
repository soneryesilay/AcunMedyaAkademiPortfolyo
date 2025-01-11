using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult EditAbout(int id)
        {
            var value = db.TblAbout.Find(id);
            return View(value);
        }

        [HttpPost]

        public ActionResult EditAbout(TblAbout p)
        {
            var value = db.TblAbout.Find(p.AboutId);
            value.AboutTitle = p.AboutTitle;
            value.About1 = p.About1;
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}