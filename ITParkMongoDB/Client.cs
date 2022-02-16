using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Client
    {
        public Client(string nameOfProduct, double cash, double countOfProduct)
        {
            NameOfProduct = nameOfProduct;
            Cash = cash;
            CountOfProduct = countOfProduct;
        }

        public string NameOfProduct { get; set; }
        public double Cash { get; set; }
        public double CountOfProduct { get; set; }

    }
}
