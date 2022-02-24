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
        public DiscountCard CliensDiscountCard { get; set; }



        [BsonElement("Cart")]
        public Cart clientsCart = new Cart();

        public Client(string name)
        {
            Name = name;
            CliensDiscountCard = new DiscountCard(111);
        }

        public void Buy(string name, string category, double count)
        {
            
            var list = DataBaseMethods.ShowProductsInCategory(category);           
            if(list.Exists(x=> x.NameOfProduct == name))
            {
                var current = list.Find(x => x.NameOfProduct == name);

                if(current.CountAtWarehouse >= count) 
                {
                    current.CountAtWarehouse -= count;
                    DataBaseMethods.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(current, Name);
                    CliensDiscountCard.SetTotalCurrency(clientsCart.Currency); 
                    Console.WriteLine(current.NameOfProduct + " " + current.Manufacturer + " " + current.CountAtWarehouse);
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
            foreach (var item in clientsCart.cart)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.CountAtWarehouse}");
            }

            Console.WriteLine("Total cost is: " + clientsCart.Currency);
        }

        public static void ClientsLog(Client client)
        {
            var list = DataBaseMethods.FindClient(client.Name);
            if(list.Exists(x => x.Name == client.Name))
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
