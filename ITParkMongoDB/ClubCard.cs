using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class ClubCard
    {
        public ClubCard()
        {
        }

        public ClubCard(int numberOfclubCard, int points, string currentDiscount, string currentStatus)
        {
            NumberOfclubCard = numberOfclubCard;
            Points = points;
            CurrentDiscount = currentDiscount;
            CurrentStatus = currentStatus;
        }

        public int NumberOfclubCard { get; set; }
        public int Points { get; set; }
        public string CurrentDiscount { get; set; }
        public string CurrentStatus { get; set; }
        //[BsonElement("ShoppingClubCard")]
        //public ClubCard clientsCard = new ClubCard();

        

        //public void AddToClubCard(Client client)
        //{
        //    clientsCard = DataBaseMethods.GetCart(name);
        //}


    }
}
