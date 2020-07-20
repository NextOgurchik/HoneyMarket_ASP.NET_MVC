using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HoneyMarket.Models;

namespace HoneyMarket.Controllers
{
    public class HomeController : Controller
    {
        readonly HoneyContext honeyContext = new HoneyContext();
        public ActionResult Index()
        {
            IEnumerable<Honey> honeys = honeyContext.Honeys;

            ViewBag.Honeys = honeys;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.DateTime = DateTime.Now;
            honeyContext.Purchases.Add(purchase);
            return purchase.FIO + ", покупка прошла успешно!";
        }
    }
}