using AcunMedyaAkademiPortfolyo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class ContactController : Controller
    {
        // Veritabanı bağlantısını burada yapıyoruz
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();

        // GET: Contact (İletişim formu sayfası)
        public ActionResult ContactList()
        {
            var values = db.TblContacts.ToList(); // Veritabanındaki tüm iletişim verilerini getir
            return View(values);
        }

        // GET: İletişim formunu gösterme
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateContact(TblContacts contacts)
        {
            
                    db.TblContacts.Add(contacts);
                    db.SaveChanges();
            return RedirectToAction("Default","Index");


        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContacts.Find(id);
            db.TblContacts.Remove(value);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }


    }
}