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
        public List<Product> productList;

        public Cart()
        {
            Currency = 0;
            dateOfbuy = DateTime.Now.Date;
            productList = new List<Product>();
        }

        public void AddToCart(Product product, string name)
        {
            GetCart(name);

            if (productList.Exists(x => x.NameOfProduct == product.NameOfProduct && x.Manufacturer == product.Manufacturer))
            {
                var current = productList.Find(x => x.NameOfProduct == product.NameOfProduct && x.Manufacturer == product.Manufacturer);
                current.CountAtWarehouse += product.CountAtWarehouse;
                
            }
            else
            {
                productList.Add(product);
            }
            
            Currency = SetCurrency();
        }



        private double SetCurrency()
        {
            double localCurrency = 0;
            foreach (var item in productList)
            {
                localCurrency += item.Price * item.CountAtWarehouse;
            }
            return localCurrency;
        }

        public void GetCart(string name)
        {
            productList = DataBaseMethods.GetCart(name).productList;
        }
    }
}
