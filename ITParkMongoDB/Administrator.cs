using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITParkMongoDB
{
    class Administrator 
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string fillial { get; set; }
        public string vacancy { get; set; }

        public void AddProductToDatabase(Product product)
        {
            DataBaseMethods.AddProductToDatabase(product);
        }

    }
}
