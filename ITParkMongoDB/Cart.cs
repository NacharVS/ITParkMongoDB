using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Cart
    {
        public double Currency { get; set; }
        public DateTime dateOfbuy;
        public List<Product> cart;

        public Cart()
        {
            Currency = 0;
            dateOfbuy = DateTime.Now.Date;
            cart = new List<Product>();
        }

        public void AddToCart(Product product)
        {
            cart.Add(product);
            Currency = SetCurrency();
        }

        private double SetCurrency()
        {
            double localCurrency = 0;
            foreach (var item in cart)
            {
                localCurrency += item.Price * item.CountAtWarehouse;
            }
            return localCurrency;
        }
    }
}
