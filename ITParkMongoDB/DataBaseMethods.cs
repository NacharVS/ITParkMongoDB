﻿using MongoDB.Driver;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class DataBaseMethods
    {
        public static void AddProductToDatabase(Product product)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Product>(product.TypeOfProduct);
            collection.InsertOne(product);
        }

        public static List<Product> ShowProductsInCategory(string category)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Product>(category);
            return collection.Find(x => true).ToList();
        }

        public static void AddMerchToDatabase(Mechendaiser merch)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Mechendaiser>(merch.vacancy);
            collection.InsertOne(merch);
        }
        public static void AddAdminToDatabase(Administrator admin)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>(admin.vacancy);
            collection.InsertOne(admin);
        }

        public static void FindAdmin(string surnameParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>("Administrator");
            var list = collection.Find(x => x.surname == surnameParam).ToList();

            if (list.Count != 0)
            {
                System.Console.Write("Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.name} {item.surname}");
                }
            }
            else
                System.Console.WriteLine("Current admin not exist in data base");
        }

        public static void ReplaceAdmin(string nameToReplace, Administrator newInfo)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>("Administrator");
            collection.ReplaceOne(x => x.name == nameToReplace, newInfo);
        }

        public static void ReplaceProduct(Product product)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Product>(product.TypeOfProduct);
            collection.ReplaceOne(x => x.NameOfProduct == product.NameOfProduct, product);
        }

        public static List<string> GetCollections()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            return database.ListCollectionNames().ToList();
        }
        public static void AddClientToDatabase(Client client1)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            collection.InsertOne(client1);
        }

        public static void ReplaceClientToDatabase(Client client1)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            collection.ReplaceOne(x => x.Name == client1.Name, client1);
        }
        public static List<Client> FindClient(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            return collection.Find(x => x.Name == name).ToList();
        }

        public static Cart GetCart(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var client1 = collection.Find(x => x.Name == name).FirstOrDefault();
            return client1.clientsCart;
        }




    }
}
