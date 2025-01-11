using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ProjectController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        // GET: Project
        public ActionResult ProjectList()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TblProject experience)
        {
            db.TblProject.Add(experience);
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

        public ActionResult DeleteProject(int id)
        {
            var value = db.TblProject.Find(id);
            db.TblProject.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ProjectList");

        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.TblProject.Find(id);
            return View("UpdateProject", value);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject experience)
        {
            var value = db.TblProject.Find(experience.ProjectId);
            value.ProjectTitle = experience.ProjectTitle;
            value.Description = experience.Description;
            value.ImageUrl = experience.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("ProjectList");
        }

    }
}