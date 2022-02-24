using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            //Administrator.AddDiscountCard("Vadim", "0");
            //DataBaseMethods.AddProductToDatabase(new Product("Tomato", 200, 90, "Egoryevskie Teplici", "Food", new List<string>() { "bbb, qqq, zzz"}));
            Client client = new Client("Grisha");
            //DataBaseMethods.UpdateSomething("Food", "Tomato", 10);
            //DataBaseMethods.AddToCliensCart();
            //Client.ClientsLog(client);
            client.Buy("RedCaviar", "Food", 2);
            //client.Buy("Bread", "Food", 5);
            Client.ClientsLog(client);
            
            //Client.ClientsLog(client);
            //client.ShowCart();
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //admin1.AddProductToDatabase(new Product("RedCaviar", 1000, 20, "Vladivostok", "Food", new List<string> { "Pelikan", "Persten", "Samobranka" }));
            ////DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));


            //  1. Реализовать клубную карту отдельным классом, с полями номер карты,
            //  накопленные баллы(за каждую 1000 у.е. начисляется 1 монетка), скидка по карте,
            //  статус карты(чем выше статус - тем больше скидка)


        }
    }
}
