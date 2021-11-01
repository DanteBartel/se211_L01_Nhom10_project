using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BTL_CNPM.Models;

namespace BTL_CNPM.Controllers
{
    public class ShopingCartController : Controller
    {
        FoodOrderingEntitiesProduct _db = new FoodOrderingEntitiesProduct();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if(cart == null|| Session["Cart"]== null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
           return cart;
        }
        public ActionResult Addtocart(int id)
        {
            var pro = _db.Products.SingleOrDefault(s => s.IDPro == id);
            if(pro !=null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ShowtoCart", "ShopingCart");
        }
        public ActionResult ShowtoCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("ShowtoCart", "ShopingCart");
            Cart cart = Session["Cart"] as Cart;
            return View(cart);

        }
    }
}