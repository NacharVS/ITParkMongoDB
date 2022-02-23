using System;
using System.Collections.Generic;

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


        public void AddToCart(string nameOfClient, Product product)
        {
            cart = DataBaseMethods.GetCart(nameOfClient).cart;
            //GetCart(nameOfClient);

            if (cart.Exists(x => x.NameOfProduct == product.NameOfProduct))
            {
                var current = cart.Find(x => x.NameOfProduct == product.NameOfProduct);
                current.CountAtWarehouse += product.CountAtWarehouse;
            }
            else
            {
                cart.Add(product);
            }

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


        //public void AddToCart(string nameOfClient, Product product, double count)
        //{
        //    var currentProduct = product;
        //    currentProduct.CountAtWarehouse = count;

        //    cart = DataBaseMethods.GetCart(nameOfClient).cart;
        //    //GetCart(nameOfClient);
        //    if (cart.Exists(x => x.NameOfProduct == product.NameOfProduct))
        //    {
        //        var current = cart.Find(x => x.NameOfProduct == product.NameOfProduct);
        //        current.CountAtWarehouse += currentProduct.CountAtWarehouse;
        //    }
        //    else
        //    {
        //        cart.Add(currentProduct);
        //    }

        //    Currency = SetCurrency();
        //}


        //public void GetCart(string name)
        //{
        //    cart = DataBaseMethods.GetCart(name).cart;
        //}


    }
}
