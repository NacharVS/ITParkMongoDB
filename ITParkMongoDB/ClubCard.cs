using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    internal class ClubCard
    {
        public int Number { get; set; }
        public double BallCart { get; set; }
        public string DiscountCart { get; set; }
        public string StatusCart { get; set; }

        public ClubCard(int number, double ballCart, string discountCart, string statusCart)
        {
            Number = number;
            BallCart = ballCart;
            DiscountCart = discountCart;
            StatusCart = statusCart;
        }

        public ClubCard()
        {
        }
    }
}
