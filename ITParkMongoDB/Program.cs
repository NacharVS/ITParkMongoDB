using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //DataBaseMethods.AddProductToDatabase(new Product("Tomato", 200, 90, "Egoryevskie Teplici", "Food", new List<string>() { "bbb, qqq, zzz"}));
            //Client client = new Client("Grisha");
            DataBaseMethods.UpdateSomething("Food", "Tomato", 10);
            //Client.ClientsLog(client);
            //client.Buy("Bread", "Food", 5);
            //Client.ClientsLog(client);
            //client.ShowCart();
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));
            //  Доработать текущий код, чтобы если такого клиента нет в бд -  клиент добавлялся, а если есть - обновлялся. 
            

        }
    }
}
