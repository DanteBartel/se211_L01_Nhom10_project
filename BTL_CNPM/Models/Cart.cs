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
        public void Update_Quantity(int id, int _quantity)
        {
            var item = items.Find(s => s._shopping_product.IDPro == id);
             if (item !=null)
            {
                item._shopping_quantity = _quantity;
            }
        }
        public double Total()
        {
            double item = items.Sum(s => Convert.ToDouble(s._shopping_product.Pro_Price) * s._shopping_quantity);
            return item;
        }
        public void Remove(int id)
        {
            items.RemoveAll(s => s._shopping_product.IDPro == id);

        }
        public int Total_Quantity()
        {
            int item =items.Sum(s => s._shopping_quantity);
            return item;
        }
    }
   
}