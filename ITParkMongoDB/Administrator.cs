using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    public class Administrator 
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
        public Object _id;
        [BsonElement("NameOfAdmin")]
        [BsonIgnoreIfDefault]
        public string name { get; set; }
        [BsonIgnoreIfDefault]
        public string surname { get; set; }
        [BsonIgnoreIfDefault]
        public string vacancy { get; set; }

        [BsonIgnoreIfDefault]
        public int DriverCard { get; set; }

        [BsonIgnoreIfNull]
        public string Education { get; set; }
        public void AddProductToDataBase (Product product)
        {
           DataBase.AddProductToDataBase(product);
        }

        public void UpdateNameClient(string name, string name2)
        {
            DataBase.UpdateNameClient(name, name2);
        }
        public  void UpdateClubCartSilver(string nameOfClien)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var update = Builders<Client>.Update.Set(x => x.clubCard, new Club_card(111, "Silver status", 5, 0));
            collection.UpdateOne(x => x.Name == nameOfClien, update);
        }
        public  void UpdateClubCartGolden( string nameOfClien)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var update = Builders<Client>.Update.Set(x => x.clubCard, new Club_card(112, "Golden status", 15, 0));
            collection.UpdateOne(x => x.Name == nameOfClien, update);
        }

        public  void UpdateClubCartPlatinum (string nameOfClien)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Magnit");
            var collection = database.GetCollection<Client>("Logs");
            var update = Builders<Client>.Update.Set(x => x.clubCard, new Club_card(113, "Platinum status", 25, 0));
            collection.UpdateOne(x => x.Name == nameOfClien, update);
        }

            

        //public void AddDiscountCard(string nameOfClient, string command)
        //{
        //    UpdateDefinition<Client> defenition;
        //    UpdateDefinition<Client> defenitionUnset;
        //        var client = new MongoClient("mongodb://localhost");
        //        var database = client.GetDatabase("Magnit");
        //        var collection = database.GetCollection<Client>("Logs");
        //    if (command=="0")
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
