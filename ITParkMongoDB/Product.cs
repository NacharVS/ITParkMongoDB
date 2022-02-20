using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Product
    {
        public Product(string nameOfProduct, double price, double countAtWarehouse, string manufacturer, string typeOfProduct, List<string> listOfFillials)
        {
            NameOfProduct = nameOfProduct;
            Price = price;
            CountAtWarehouse = countAtWarehouse;
            Manufacturer = manufacturer;
            TypeOfProduct = typeOfProduct;
            ListOfFillials = listOfFillials;
        }



        [BsonId]
        //[BsonIgnoreIfDefault]
        public ObjectId _id;
        public string NameOfProduct { get; set; }
        public double Price { get; set; }
        public double CountAtWarehouse { get; set; }
        public string Manufacturer { get; set; }
        public string TypeOfProduct { get; set; }
        [BsonIgnoreIfNull]
        public List<string> ListOfFillials { get; set; }
    }
}
