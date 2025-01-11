using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolyo.Models;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class StatisticsController : Controller
    {
        dbAcunMedyaAkademiEntities db = new dbAcunMedyaAkademiEntities();
        // GET: Statistics
        public ActionResult StatisticList()
        {
            var values = db.TblStatistic.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateStatistic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStatistic(TblStatistic statistic)
        {
            db.TblStatistic.Add(statistic);
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

        public ActionResult DeleteStatistic(int id)
        {
            var value = db.TblStatistic.Find(id);
            db.TblStatistic.Remove(value);
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

        [HttpGet]
        public ActionResult UpdateStatistic(int id)
        {
            var value = db.TblStatistic.Find(id);
            return View("UpdateStatistic", value);
        }

        [HttpPost]
        public ActionResult UpdateStatistic(TblStatistic statistic)
        {
            var value = db.TblStatistic.Find(statistic.StatisticId);
            value.StatisticTitle = statistic.StatisticTitle;
            value.StatisticIcon = statistic.StatisticIcon;  
            value.StatisticValue = statistic.StatisticValue;
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

    }
}