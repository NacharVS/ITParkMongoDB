using MongoDB.Bson;
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

        [BsonElement("Cart")]
        public Cart clientsCart = new Cart();
        
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
            if (list.Exists(x => x.Name == client.Name))
            {
                DataBaseMethods.ReplaceClientToDatabase(client);
            }
            else
            {
                DataBaseMethods.AddClientToDatabase(client);
            }
        }

        public void Buy(string nameOfClient, string name, string category, double count)
        {
            var list = DataBaseMethods.ShowProductsInCategory(category);
            if (list.Exists(x => x.NameOfProduct == name))
            {
                var current = list.Find(x => x.NameOfProduct == name);
                if (current.CountAtWarehouse >= count)
                {
                    current.CountAtWarehouse -= count;
                    //DataBaseMethods.ReplaceProduct(current);
                    current.CountAtWarehouse = count;
                    clientsCart.AddToCart(nameOfClient, current, count);
                    Console.WriteLine($"{nameOfClient} has bought {count} of {current.NameOfProduct}");
                    Console.WriteLine(current.NameOfProduct + " " + current.Manufacturer + " " + current.CountAtWarehouse);
                }
                else
                {
                    //Console.WriteLine("Not enough products in warehouse");current
                    Console.WriteLine($"{this.Name} has bought {current.CountAtWarehouse} of {current.NameOfProduct}");
                    Console.WriteLine($"It's not enough. The lack of {current.NameOfProduct} is {count - current.CountAtWarehouse}");
                    current.CountAtWarehouse = 0;
                    if (current.CountAtWarehouse > 0)  clientsCart.AddToCart(nameOfClient, current, current.CountAtWarehouse);
                }
                DataBaseMethods.ReplaceProduct(current);
            }
            else
                Console.WriteLine("Not found");
        }

        /*
        public void BuyProduct(string nameOfProduct, string typeOfProduct, double quantity)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");         
            var collection = database.GetCollection<Product>(typeOfProduct);
            //Product product
            var list = collection.Find(x => x.NameOfProduct == nameOfProduct).ToList();

            if (list.Count != 0)
            {
                Product product = list[0];
                if (product.CountAtWarehouse >= quantity)
                {
                    product.CountAtWarehouse -= quantity;
                    Console.WriteLine($"{this.Name} has bought {quantity} of {product.NameOfProduct}");
                }

                else
                {                    
                    Console.WriteLine($"{this.Name} has bought {product.CountAtWarehouse} of {product.NameOfProduct}");
                    Console.WriteLine($"It's not enough. The lack of {product.NameOfProduct} is {quantity - product.CountAtWarehouse}");
                    product.CountAtWarehouse = 0;
                }

                DataBaseMethods.ReplaceProduct(product);
            }
            else Console.WriteLine("The product is not founded");
        }
        */
    }
}
