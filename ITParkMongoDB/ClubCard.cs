using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class ClubCard
    {
        public int ClubNumber { get; set; }

        public DateTime dateOfcreate;

        public int AccumulatedPoints { get; set; }

        public int Discount { get; set; }

        public TypeOfCard CardStatus { get; set; }


        public ClubCard(int clubNumber, TypeOfCard cardStatus)
        {
            ClubNumber = clubNumber;
            dateOfcreate = DateTime.Now;
            AccumulatedPoints = 0;
            Discount = 1;
            CardStatus = cardStatus;

            switch (cardStatus)
            {
                case TypeOfCard.LoyaltyCard:
                    Discount = 2;
                    break;
                case TypeOfCard.SocialCard:
                    Discount = 5;
                    break;
                case TypeOfCard.VIPCard:
                    Discount = 10;
                    break;
                default:
                    break;
            }
        }

        public void Accumulated (double currency)
        {
            AccumulatedPoints += (int)currency / 1000; 
        }








    }
}
