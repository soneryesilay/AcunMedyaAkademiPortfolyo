using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class SocialMediaController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        public ActionResult SocialMediaList()
        {
            var values = db.TblSocialMedia.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSocialMedia(TblSocialMedia socialMedia)
        {
            db.TblSocialMedia.Add(socialMedia);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            db.TblSocialMedia.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedia.Find(id);
            return View("UpdateSocialMedia", value);
        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia SocialMediaParametry)
        {
            var value = db.TblSocialMedia.Find(SocialMediaParametry.SocialMediaId);
            value.SocialMediaLink = SocialMediaParametry.SocialMediaLink;
            value.SocialMediaIcon = SocialMediaParametry.SocialMediaIcon;
            db.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }
    }
}