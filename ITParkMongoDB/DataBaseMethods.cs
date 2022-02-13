using MongoDB.Driver;
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

        public static List<Product>  ShowProductsInCategory(string category)
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

            if(list.Count != 0)
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
    }
}
