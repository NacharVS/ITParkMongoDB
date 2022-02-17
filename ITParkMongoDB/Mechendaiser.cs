using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    public class Mechendaiser
    {
        public Mechendaiser(string name, string surname, string fillial, string vacancy, string education)
        {
            this.name = name;
            this.surname = surname;
            this.fillial = fillial;
            this.vacancy = vacancy;
            Education = education;
        }

        public Mechendaiser(string name, string surname, string fillial, string vacancy, int driverCard, string education)
        {
            this.name = name;
            this.surname = surname;
            this.fillial = fillial;
            this.vacancy = vacancy;
            DriverCard = driverCard;
            Education = education;
        }

        public Mechendaiser(string name, string surname, string fillial, string vacancy)
        {
            this.name = name;
            this.surname = surname;
            this.fillial = fillial;
            this.vacancy = vacancy;
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id;
        [BsonElement("NameOfMerchendaiser")]
        public string name { get; set; }
        public string surname { get; set; }
        public string fillial { get; set; }
        public string vacancy { get; set; }
        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }
        [BsonIgnoreIfNull]
        public string Education { get; set; }
    }
}
