using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseMethods.ReplaceAdmin("Sergey", new Administrator("Sergey", "Ivanov", "Administrator", 987654, "High"));
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));

            //1. Добавить по 5 товаров в разные категории(всего 4 категории)
            //2. Реализовать класс Client и в нём, реализовать метод покупки товара, с условием,
            //   что на складе(в базе данных) товар уменьшается после покупки.
            // 
            

        }
    }
}
