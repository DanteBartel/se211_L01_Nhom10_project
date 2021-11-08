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
        FoodOrderingEntitiesPro _db = new FoodOrderingEntitiesPro();
        public ActionResult Index()
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