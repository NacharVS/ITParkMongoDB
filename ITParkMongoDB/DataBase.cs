

using MongoDB.Driver;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    public class DataBase
    {
       public static void AddProductToDataBase(Product product)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>(product.TypeOfProduct);
            collection.InsertOne(product);
        }

        public static List<Product> ShowProductInCategory (string category)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>(category);
            return collection.Find(x => true).ToList();
        }
        public static void AddMechendaiserToDataBase(Mechendaiser mechendaiser)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Mechendaiser>(mechendaiser.vacancy);
            collection.InsertOne(mechendaiser);
        }
        public static void AddAdministratorToDataBase(Administrator administrator)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>(administrator.vacancy);
            collection.InsertOne(administrator);
        }

        public static void FindAdmin(string surnameParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>("Administrator");
            var list = collection.Find(x => x.surname == surnameParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list) 
                {
                    System.Console.WriteLine($"{item.name} {item.surname}");
                }
            }
            else
            {
                System.Console.WriteLine($"Current admin not exist in data base");
            }
        }

        public static void ReplaceAdmin(string nameToReplace, Administrator newInfo)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Administrator>("Administrator");
            collection.ReplaceOne(x=> x.name == nameToReplace, newInfo);
        }
        public static void FindProductinCheese(string nameOfProductParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Cheese");
            var list = collection.Find(x => x.NameOfProduct == nameOfProductParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.NameOfProduct}.Number of pieces in stock {item.CountAtWarehouse}");
                }
            }
            else
            {
                System.Console.WriteLine($"This product is not in stock");
            }
        }
        public static void ReplaceProductCheese(string productToReplace, Product newInfo)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Cheese");
            collection.ReplaceOne(x => x.NameOfProduct == productToReplace, newInfo);
        }
        public static void FindProductinCosmeticsHygiene(string nameOfProductParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Cosmetics and hygiene");
            var list = collection.Find(x => x.NameOfProduct == nameOfProductParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.NameOfProduct}.Number of pieces in stock {item.CountAtWarehouse}");
                }
            }
            else
            {
                System.Console.WriteLine($"This product is not in stock");
            }
        }
        public static void FindProductinGrocery(string nameOfProductParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Grocery");
            var list = collection.Find(x => x.NameOfProduct == nameOfProductParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.NameOfProduct}.Number of pieces in stock {item.CountAtWarehouse}");
                }
            }
            else
            {
                System.Console.WriteLine($"This product is not in stock");
            }
        }
        public static void FindProductinMeatGastronomy(string nameOfProductParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Meat gastronomy");
            var list = collection.Find(x => x.NameOfProduct == nameOfProductParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.NameOfProduct}.Number of pieces in stock {item.CountAtWarehouse}");
                }
            }
            else
            {
                System.Console.WriteLine($"This product is not in stock");
            }
        }
        public static void FindProductinSweets(string nameOfProductParam)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Products");
            var collection = database.GetCollection<Product>("Sweets");
            var list = collection.Find(x => x.NameOfProduct == nameOfProductParam).ToList();
            if (list.Count != 0)
            {
                System.Console.WriteLine($"Found:");
                foreach (var item in list)
                {
                    System.Console.WriteLine($"{item.NameOfProduct}.Number of pieces in stock {item.CountAtWarehouse}");
                }
            }
            else
            {
                System.Console.WriteLine($"This product is not in stock");
            }
        }



    }
}
