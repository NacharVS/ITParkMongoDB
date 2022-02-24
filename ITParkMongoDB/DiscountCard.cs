using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ITParkMongoDB
{
    class DiscountCard
    {
        public DiscountCard(int cardNumber)
        {
            CardNumber = cardNumber;
            DiscountValue = 0.01;
            CardStatus = "Base";
            Bonuses = 0;
            TotalCurrency = 0;
        }

        [BsonIgnore]

        public ObjectId _id { get; set; }
        [BsonElement("Number")]
        public int CardNumber { get; set; }
        [BsonElement("Value")]
        public double DiscountValue { get; set; }
        [BsonElement("Status")]
        public string  CardStatus { get; set; }
        [BsonElement("BonusPoints")]
        public int Bonuses { get; set; }
        [BsonElement("Total")]
        public double TotalCurrency { get; set; }

        public void DiscountPick()
        {
            if(TotalCurrency > 0 && TotalCurrency < 3000)
            {
                DiscountValue = 0.03;
            }
            else
            if (TotalCurrency > 3000 && TotalCurrency < 5000)
            {
                DiscountValue = 0.05;
            }
            else
            if (TotalCurrency > 5000 )
            {
                DiscountValue = 0.10;
            }
            if(TotalCurrency > 10000)
            {
                CardStatus = "Silver";
            }
        }

        public double GetDiscount()
        {
            if(CardStatus == "Silver")
            {
                return DiscountValue * 1.3;
            }
            else
            {
                return DiscountValue;
            }
        }

        public void SetTotalCurrency(double value)
        {
            TotalCurrency += value;
        }


    }
}
