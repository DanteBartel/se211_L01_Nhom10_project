using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_CNPM.Models
{
    public class CartItem
    {
        public Product _shopping_product { get; set; }
        public int _shopping_quantity { get; set; }
    }
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(Product _pro, int _quantity = 1)
        {
            var item = items.FirstOrDefault(s => s._shopping_product.IDPro == _pro.IDPro);
            if (item ==null)
            {
                items.Add(new CartItem
                {
                    _shopping_product = _pro,
                    _shopping_quantity = _quantity
                }); ;
            }
            else
            {
                item._shopping_quantity += _quantity;
            }
    }
    }
   
}