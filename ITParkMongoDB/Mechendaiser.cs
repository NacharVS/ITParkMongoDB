using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Mechendaiser
    {
        public Mechendaiser(string name, string surname, string fillial, string vacancy, string education)
        {
            this.name = name;
            this.surname = surname;
            this.fillial = fillial;
            this.vacancy = vacancy;
            Education = education;
        }

        public ObjectId _id;
        public string name { get; set; }
        public string surname { get; set; }
        public string fillial { get; set; }
        public string vacancy { get; set; }

        public string Education { get; set; }
    }
}
