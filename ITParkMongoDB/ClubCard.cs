using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    internal class ClubCard
    {
        public ClubCard(int numberCart, int ballCart, string discountCart, string statusCart)
        {
            NumberCart = numberCart;
            BallCart = ballCart;
            DiscountCart = discountCart;
            StatusCart = statusCart;
        }

        public int NumberCart { get; set; }
        public int BallCart { get; set; }
        public string DiscountCart { get; set; }
        public string StatusCart { get; set; }

    }
}
