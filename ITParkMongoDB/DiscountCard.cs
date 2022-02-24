using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ITParkMongoDB
{
    class DiscountCard
    {
        [BsonIgnore]
        private double _discountValue;
        public DiscountCard(int cardNumber)
        {
            CardNumber = cardNumber;
            DiscountValue = 0.01;
            CardStatus = "Base";
            Bonuses = 0;
            TotalCurrency = 0;
        }

        [BsonId]

        public ObjectId _id { get; set; }
        [BsonElement("Number")]
        public int CardNumber { get; set; }
        [BsonElement("Value")]
        public double DiscountValue
        {
            get => GetDiscount();
            set
            {
                _discountValue = GetDiscount();
            }
        }
        [BsonElement("Status")]
        public string  CardStatus { get; set; }
        [BsonElement("BonusPoints")]
        public int Bonuses { get; set; }
        [BsonElement("Total")]
        public double TotalCurrency { get; set; }

        public double DiscountPick()
        {
            if(TotalCurrency > 0 && TotalCurrency < 3000)
            {
                return 0.03;
            }
            else
            if (TotalCurrency > 3000 && TotalCurrency < 5000)
            {
                return  0.05;
            }
            else
            if (TotalCurrency > 5000 )
            {
                return 0.1;
            }
            else
            if(TotalCurrency > 10000)
            {
                CardStatus = "Silver";
                return 0.1;
            }
            return 0.01;
        }

        public double GetDiscount()
        {
            if(CardStatus == "Silver")
            {
                return DiscountPick() * 1.3;
            }
            else
            {
                return DiscountPick();
            }
        }

        public void SetTotalCurrency(double value)
        {
            TotalCurrency += value;
        }


    }
}
