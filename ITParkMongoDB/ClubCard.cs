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
        public int NumberOfclubCard { get; set; }
        public int Points { get; set; }
        public int CurrentDiscount { get; set; }
        public int CurrentStatus { get; set; }
        //[BsonElement("ShoppingClubCard")]
        //public ClubCard clientsCard = new ClubCard();

        public ClubCard()
        {
            NumberOfclubCard = 1;
            Points = 2;
            CurrentDiscount = 3;
            CurrentStatus = 4;
        }

        //public void AddToClubCard(Client client)
        //{
        //    clientsCard = DataBaseMethods.GetCart(name);
        //}


    }
}
