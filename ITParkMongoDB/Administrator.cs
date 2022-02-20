using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

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

        public void UpdateClient(string name, string newName)
        {
            DataBaseMethods.UpdateClient("Logs", name, newName);
        }

    }
}
