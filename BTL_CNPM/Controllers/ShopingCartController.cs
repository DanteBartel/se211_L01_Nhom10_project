using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows;
using BTL_CNPM.Models;

namespace BTL_CNPM.Controllers
{
    public class ShopingCartController : Controller
    {
        FoodOrderingEntities _db = new FoodOrderingEntities();
        public Cart GetCart()
        {
            // Tao session luu thong tin khi 1 client connect
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
            return RedirectToAction("Index", "Home");
        }
        public ActionResult ShowtoCart()
        {
            if (Session["Cart"] == null)
                return RedirectToAction("Index", "Home");
            Cart cart = Session["Cart"] as Cart;  
            return View(cart);
        }
        public ActionResult Update_Qty_Cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            int id = int.Parse(form["IDpro"]);
            int quantity = int.Parse(form["Quantity"]);
            cart.Update_Quantity(id, quantity);

            return RedirectToAction("ShowtoCart", "ShopingCart");
        }
        public ActionResult Remove(int id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove(id);
            return RedirectToAction("ShowtoCart", "ShopingCart");
        }
        public PartialViewResult Total_Items_Cart()
        {
            int total_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if (cart != null)

                total_item = cart.Total_Quantity();
                ViewBag.QuantityCart = total_item;
                return PartialView("Total_Items_Cart");
            
        }
    }
}