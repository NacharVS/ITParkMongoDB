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
    }
}
