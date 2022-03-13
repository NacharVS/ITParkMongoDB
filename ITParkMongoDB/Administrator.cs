﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace ITParkMongoDB
{
    class Administrator 
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
        public ObjectId _id;
        [BsonElement("NameOfAdmin")]
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        [BsonIgnoreIfDefault]
        public string surname { get; set; }
        [BsonIgnoreIfDefault]
        public string vacancy { get; set; }

        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }
        [BsonIgnoreIfDefault]
        public string Education { get; set; }

        public void AddProductToDatabase(Product product)
        {
            DataBaseMethods.AddProductToDatabase(product);
        }
        public static void AddClubCardBronze(string nameOfClient)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var defenition = Builders<Client>.Update.Set(x => x.clubCard, new ClubCard(12, 200, "95%", "Bronze"));
            collection.UpdateOne(x => x.Name == nameOfClient, defenition);
        }
        public static void AddClubCardSilver(string nameOfClient)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var defenition = Builders<Client>.Update.Set(x => x.clubCard, new ClubCard(12, 500, "90%", "Silver"));
            collection.UpdateOne(x => x.Name == nameOfClient, defenition);
        }
        public static void AddClubCardGold(string nameOfClient)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var defenition = Builders<Client>.Update.Set(x => x.clubCard, new ClubCard(12, 1000, "80%", "Gold"));
            collection.UpdateOne(x => x.Name == nameOfClient, defenition);
        }
    }
}
