using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();

        // GET: Category
        public ActionResult CategoryList()
        {
            var values  = db.TblCategory.ToList(); // to list = Select * from
            return View(values);     //return view gözükürken değeleri de beraberinde getirsin
        }

        [HttpGet]   //sayfa yüklendiğinde
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]   //sayfa yüklendiğinde
        public ActionResult CreateCategory(TblCategory category)
        {
            db.TblCategory.Add(category);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        //silme işlemi için bir attribute gerekmiyor sadece id'yi alıp silmek yeterli
        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategory.Find(id);
            db.TblCategory.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");   
        }

        [HttpGet]
        public ActionResult UpdateCategory (int id)
        {
            var value = db.TblCategory.Find(id);
            return View("UpdateCategory", value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategory categoryParametry)
        {
            var value = db.TblCategory.Find(categoryParametry.CategoryId);
            value.CategoryName = categoryParametry.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}