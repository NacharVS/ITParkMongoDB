using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Vadim");
            
            Client.ClientsLog(client);

            Administrator.AddClubCardGold("Vadim");
            //client.ShowCart();
            //client.Buy("Shampoo", "Cosmetic", 5);
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //admin1.AddProductToDatabase(new Product("Bread", 30, 80, "ChelnyKhleb", "Food", new List<string> { "Pelikan", "Persten", "Medovik" }));
            //admin1.AddProductToDatabase(new Product("Butter", 120, 50, "Vamin", "Food", new List<string> { "Pelikan", "Persten", "Samobranka" }));
            //admin1.AddProductToDatabase(new Product("Shampoo", 300, 60, "P&G", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Aspirine", 30, 120, "Farm", "Medical", new List<string> { "Apteka", "Box", "Znakhar" }));


            //DataBaseMethods.AddProductToDatabase(new Product("Tomato", 200, 90, "Egoryevskie Teplici", "Food", new List<string>() { "bbb, qqq, zzz"}));
            //Client client = new Client("Grisha");
            ////DataBaseMethods.UpdateSomething("Food", "Tomato", 10);
            //DataBaseMethods.AddToCliensCart();
            //Client.ClientsLog(client);
            //client.Buy("Bread", "Food", 5);
            //Client.ClientsLog(client);
            //client.ShowCart();

            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));


            //  1. Реализовать клубную карту отдельным классом, с полями номер карты,
            //  накопленные баллы(за каждую 1000 у.е. начисляется 1 монетка), скидка по карте,
            //  статус карты(чем выше статус - тем больше скидка)


        }
    }
}
