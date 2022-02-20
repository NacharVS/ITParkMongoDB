using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Client
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        public string Name { get; set; }
        [BsonElement("Cart")]
        public Cart clientsCart = new Cart();

        public Client(string name)
        {
            Name = name;
        }

        public void Buy(string nameOfProduct, double count, string manufacturer, string typeOfProduct)
        {
            var list = DataBaseMethods.ShowProductsInCategory(typeOfProduct);
            
            if(list.Exists(x=> x.NameOfProduct == nameOfProduct && x.Manufacturer == manufacturer))
            {
                var current = list.Find(x => x.NameOfProduct == nameOfProduct && x.Manufacturer == manufacturer);

                if(current.CountAtWarehouse >= count) 
                {
                    current.CountAtWarehouse -= count;
                    DataBaseMethods.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(current, Name);
                    Console.WriteLine($"{current.NameOfProduct}  {current.CountAtWarehouse}  {current.Manufacturer}  {current.TypeOfProduct}");
                }
                else
                {
                    Console.WriteLine("Not enough products in warehouse");
                }
                
            }
            else
                Console.WriteLine("Not found");
        }

        public void ShowCart()
        {
            foreach (var item in clientsCart.productList)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.CountAtWarehouse}");
            }

            Console.WriteLine("Total cost is: " + clientsCart.Currency);
        }

        public static void ClientsLog(Client client)
        {
            var list = DataBaseMethods.FindClient(client.Name);
            if (list.Exists(x => x.Name == client.Name))
            {
                DataBaseMethods.ReplaceClientToDatabase(client);
            }
            else
            {
                DataBaseMethods.AddClientToDatabase(client);
            }
        }
    }
}
