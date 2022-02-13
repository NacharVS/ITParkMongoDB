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

        public void AddProductToDatabase(Product product)
        {
            DataBaseMethods.AddProductToDatabase(product);
        }

    }
}
