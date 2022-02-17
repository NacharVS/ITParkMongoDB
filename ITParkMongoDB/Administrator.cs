using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    public class Administrator 
    {
        public Administrator(string name, string surname, string vacancy)
        {
            this.name = name;
            this.surname = surname;
            this.vacancy = vacancy;
        }

        public Administrator(string name, string surname, string vacancy, int driverCard, string education) : this(name, surname, vacancy)
        {
            DriverCard = driverCard;
            Education = education;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public Object _id;
        [BsonElement("NameOfAdmin")]
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        [BsonIgnoreIfDefault]
        public string surname { get; set; }
        [BsonIgnoreIfDefault]
        public string vacancy { get; set; }

        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }

        [BsonIgnoreIfNull]
        public string Education { get; set; }
        public void AddProductToDataBase (Product product)
        {
           DataBase.AddProductToDataBase(product);
        }

    }
}
