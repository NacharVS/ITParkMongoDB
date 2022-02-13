using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ObjectId _id;
        public string name { get; set; }
        public string surname { get; set; }
        public string vacancy { get; set; }

        public void AddProductToDatabase(Product product)
        {
            DataBaseMethods.AddProductToDatabase(product);
        }

    }
}
