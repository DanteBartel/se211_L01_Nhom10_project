using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_CNPM.Models;
namespace BTL_CNPM.Controllers
{
    public class HomeController : Controller
    {
        FoodOrderingEntities _db = new FoodOrderingEntities();
        public ActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult Index_combo()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult Index_mdish()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult Index_snack()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult Index_drink()
        {
            return View(_db.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}