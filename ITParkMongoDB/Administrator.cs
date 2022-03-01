using MongoDB.Bson;
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

        //public static void AddDiscountCard(string nameOfClient, string command)
        //{
        //    UpdateDefinition<Client> defenition;
        //    UpdateDefinition<Client> defenitionUnset;
        //    var client = new MongoClient("mongodb://localhost");
        //    var database = client.GetDatabase("Magnit");
        //    var collection = database.GetCollection<Client>("Logs");
        //    if (command == "0")
        //    {
        //        defenition = Builders<Client>.Update.Set(x => x.ShoppingClubCard, true);
        //        defenitionUnset = Builders<Client>.Update.Unset(x => x.VIPShoppingClubCard);
        //        collection.UpdateOne(x => x.Name == nameOfClient, defenitionUnset);
        //    }
        //    else
        //    {
        //        defenition = Builders<Client>.Update.Set(x => x.VIPShoppingClubCard, true);
        //        defenitionUnset = Builders<Client>.Update.Unset(x => x.ShoppingClubCard);
        //        collection.UpdateOne(x => x.Name == nameOfClient, defenitionUnset);
        //    }

        //    collection.UpdateOne(x => x.Name == nameOfClient, defenition);
        //}


    }
}
