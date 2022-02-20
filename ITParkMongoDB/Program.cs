using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Vadim");
            client.Buy("Shampoo", "Cosmetic", 5);
            Client.ClientsLog(client);
            client.ShowCart();
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));
            //  Доработать текущий код, чтобы если такого клиента нет в бд -  клиент добавлялся, а если есть - обновлялся. 


        }
    }
}
