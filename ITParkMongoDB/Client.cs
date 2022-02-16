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
        public Client(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;

        [BsonElement("NameOfClient")]
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        
        [BsonIgnoreIfDefault]
        public string surname { get; set; }

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
                    Console.WriteLine($"{this.name} has bought {quantity} of {product.NameOfProduct}");
                }

                else
                {                    
                    Console.WriteLine($"{this.name} has bought {product.CountAtWarehouse} of {product.NameOfProduct}");
                    Console.WriteLine($"It's not enough. The lack of {product.NameOfProduct} is {quantity - product.CountAtWarehouse}");
                    product.CountAtWarehouse = 0;
                }

                DataBaseMethods.ReplaceProduct(product);
            }
            else Console.WriteLine("The product is not founded");
        }
    }
}
