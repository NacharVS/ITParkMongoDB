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
        public Client(string name, string surname)
        {
            this.name = name;
            this.surname = surname;           
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("NameOfClient")]
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        [BsonIgnoreIfDefault]
        public string surname { get; set; }

        public void BuyingProduct(string nameproduct, int countAtWarehouse)
        {
            Console.WriteLine($"В вашей корзине:{nameproduct}, в количестве {countAtWarehouse} шт."); 
        }



    }
}
