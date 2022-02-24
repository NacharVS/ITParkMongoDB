using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Cart
    {
        [BsonIgnore]
        public double SingleBuy { get; set; }
        public double Currency { get; set; }
        public DateTime dateOfbuy;
        public List<Product> cart;

        public Cart()
        {
            Currency = 0;
            dateOfbuy = DateTime.Now;
            cart = new List<Product>();
        }

        public void AddToCart(Product product, string name)
        {
            cart = DataBaseMethods.GetCart(name).cart;
            if (cart.Exists(x => x.NameOfProduct == product.NameOfProduct))
            {
                var current = cart.Find(x => x.NameOfProduct == product.NameOfProduct);
                SingleBuy = product.CountAtWarehouse * product.Price;
                current.CountAtWarehouse += product.CountAtWarehouse;              
            }
            else
            {
                SingleBuy = product.CountAtWarehouse * product.Price;
                cart.Add(product);
            }
            
            Currency = SetCurrency() ;

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
