using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    public class Club_card
    {
        public Club_card(int cardNumber, string statusCard, double cardDiscount, int points)
        {
            CardNumber = cardNumber;
            StatusCard = statusCard;
            CardDiscount = cardDiscount;
            Points = points;
        }

        [BsonIgnoreIfDefault]
        public int  CardNumber { get; set; }
        public string StatusCard { get; set; }

        //silver status cardDiscount 5%
        //golden status cardDiscount 15%
        //platinum status cardDiscount 25%

        public double CardDiscount { get; set; } 

        public int Points { get; set; }
        //1000$ - 1$



        public static void UpdatePoints(string nameOfClient, int newPoints)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var update = Builders<Client>.Update.Set(x => x.clubCard.Points, newPoints);
            collection.UpdateOne(x => x.Name == nameOfClient, update);
        }

           

    }
}
