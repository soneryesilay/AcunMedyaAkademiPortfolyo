using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
       
        public ActionResult SkillList()
        {
            var values =db.TblSkill.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(TblSkill skill)
        {
            db.TblSkill.Add(skill);
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("SkillList");

        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View("UpdateSkill", value);
        }

        [HttpPost]
        public ActionResult UpdateSkill(TblSkill skill)
        {
            var value = db.TblSkill.Find(skill.SkillId);
           value.SkillTitle = skill.SkillTitle;
            value.SkillValue = skill.SkillValue;
            db.SaveChanges();
            return RedirectToAction("SkillList");
        }

    }
}