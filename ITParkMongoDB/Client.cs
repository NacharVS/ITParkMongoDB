﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
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

        [BsonIgnoreIfDefault]
        public bool ShoppingClubCard { get; set; } // 5% скидка
        [BsonIgnoreIfDefault]
        public bool VIPShoppingClubCard { get; set; } // 15% скидка

        [BsonElement("Cart")]
        public Cart clientsCart = new Cart();
        public ClubCard clubCard = new ClubCard();
        
        //[BsonIgnoreIfDefault]
        //public string surname { get; set; }

        //public Client(string name, string surname)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //}

        public Client(string name)
        {
            Name = name;
            var list = DataBaseMethods.FindClient(Name);
            if (list.Exists(x => x.Name == Name))
            {
                Client current = list.Find(x => x.Name == Name);
                clientsCart = current.clientsCart;
                clubCard = current.clubCard;
                ShoppingClubCard = current.ShoppingClubCard;
                VIPShoppingClubCard = current.VIPShoppingClubCard;
            }        
        }

        

        public void ShowCart()
        {
            foreach (var item in this.clientsCart.cart)
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

 
        public void Buy(string name, string category, double count)
        {
            var list = DataBaseMethods.ShowProductsInCategory(category);
            if (list.Exists(x => x.NameOfProduct == name))
            {
                var current = list.Find(x => x.NameOfProduct == name);
                if (current.CountAtWarehouse >= count)
                {
                    current.CountAtWarehouse -= count;
                    DataBaseMethods.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(Name, current);
                    //clientsCart.AddToCart(Name, current, count);

                    Console.WriteLine($"{Name} has bought {count} of {current.NameOfProduct}");
                    //Console.WriteLine(current.NameOfProduct + " " + current.Manufacturer + " " + current.CountAtWarehouse);
                }
                else
                {
                    Console.WriteLine($"{this.Name} has bought {current.CountAtWarehouse} of {current.NameOfProduct}");
                    Console.WriteLine($"It's not enough. The lack of {current.NameOfProduct} is {count - current.CountAtWarehouse}");
                    
                    if (current.CountAtWarehouse > 0)  clientsCart.AddToCart(Name, current);
                    current.CountAtWarehouse = 0;
                    DataBaseMethods.ReplaceProduct(current);
                }
                ClientsLog(this);
            }
            else
                Console.WriteLine("The product is not founded");
        }


 
    }
}
