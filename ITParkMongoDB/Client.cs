using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Client
    {
        Cart clientsCart = new Cart();
        public void Buy(string name, string category, double count)
        {
            var list = DataBaseMethods.ShowProductsInCategory(category);           
            if(list.Exists(x=> x.NameOfProduct == name))
            {
                var current = list.Find(x => x.NameOfProduct == name);
                if (current.CountAtWarehouse>=count)
                {
                    current.CountAtWarehouse -= count;
                    DataBaseMethods.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(current);
                    Console.WriteLine(current.NameOfProduct + " " + current.Manufacturer + " " + current.CountAtWarehouse);
                }
                else Console.WriteLine("Not enought");
            }
            else
                Console.WriteLine("Not found");
        }

        public void ShowCart()
        {
            foreach (var item in clientsCart.cart)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.CountAtWarehouse}");
            }

            Console.WriteLine("Total cost is:" + clientsCart.Currency);
        }
        public void ClientsLog()
        {
            var list = DataBaseMethods.FindClient(Name);

        }
    }
}
