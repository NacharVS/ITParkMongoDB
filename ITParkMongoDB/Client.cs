using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    public class Client : DataBase
    {
        public Client(string name)
        {
            this.Name = name;
            
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;

        [BsonElement("NameOfClient")]
        [BsonIgnoreIfDefault]
        public string Name { get; set; }

        //public bool ShoppingClubCard { get; set; }     // 5% скидка
        //public bool VIPShoppingClubCard { get; set; }  // 15% скидка

       
        [BsonElement("Cart")]
        public Cart clientsCart = new Cart();

        [BsonElement("ClubCard")]
        public Club_card clubCard = new Club_card(111,"SilverStatus", 5, 0);

        public void BuyingProduct(string nameproduct, string category, double count)
        {

            var list = DataBase.ShowProductInCategory(category);

            if (list.Exists(x => x.NameOfProduct == nameproduct))
            {
                var current = list.Find(x => x.NameOfProduct == nameproduct);
                if (current.CountAtWarehouse >= count)
                {
                    current.CountAtWarehouse -= count;
                    DataBase.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(current, Name);
                    Console.WriteLine($"{current.NameOfProduct} {current.Manufacturer} {current.CountAtWarehouse}");
                }
                else
                {
                    Console.WriteLine($"Not enough items in stock");
                }

            }
            else
            {
                Console.WriteLine($"Not found");
            }
            ShowCart();
            
        }
        public void ShowCart()
        {
            foreach (var item in clientsCart.cart)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.CountAtWarehouse}");
            }
            Console.WriteLine("Total cost is:" + clientsCart.Currency);
            clientsCart.Currency -= clientsCart.Currency * clubCard.CardDiscount / 100;
            Console.WriteLine($"Your club card has been discounted. Total purchase price: {clientsCart.Currency} ");
            if (clientsCart.Currency>=1000)
            {
                clubCard.Points= (int)clientsCart.Currency/1000;
                Console.WriteLine($"You got: {clubCard.Points} point");
            }
            else
                Console.WriteLine($"You got: 0 point");
        }
         

        public static void ClientsLog(Client client)
        {
            var list = DataBase.FindClient(client.Name);
            if (list.Exists(x => x.Name == client.Name))
            {
                DataBase.ReplaceClientToDataBase(client);
            }
            else
            {
                DataBase.AddClientToDataBase(client);
            }
        }

       
        


    }
}
