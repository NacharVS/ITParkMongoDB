using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {



            //DataBaseMethods.AddProductToDatabase(new Product("Bread", 45, 95, "OOO Strushkino", "Bakery", new List<string>() { "branch1", "branch2", "branch3" }));
            //DataBaseMethods.AddProductToDatabase(new Product("Bread", 40, 75, "OOO Balakovo", "Bakery", new List<string>() { "branch1", "branch2", "branch3" }));
            //DataBaseMethods.AddProductToDatabase(new Product("Bread", 56, 40, "OOO Pekarnya №1", "Bakery", new List<string>() { "branch1", "branch2", "branch3" }));
            //DataBaseMethods.AddProductToDatabase(new Product("Bread", 70, 50, "OOO The best pastries", "Bakery", new List<string>() { "branch1", "branch2", "branch3" }));

            //DataBaseMethods.ShowProductsInCategory("Bakery");

            

            Client client = new Client("Vasiliy");
            //DataBaseMethods.AddClientToDatabase(client);
            client.Buy("Bread", 5, "OOO Strushkino", "Bakery");
            Client.ClientsLog(client);



            //client.ShowCart();
            //Administrator admin1 = new Administrator("Sidor", "Sidorov", "Administrator");
            //admin1.AddProductToDatabase(new Product("Potato", 46, 125, "OOO Base №1", "Vegetables", new List<string>() { "branch1", "branch2", "branch3" }));
            //admin1.AddProductToDatabase(new Product("Onion", 33, 101, "OOO Base №1", "Vegetables", new List<string>() { "branch1", "branch2", "branch3" }));
            //admin1.AddProductToDatabase(new Product("Cabbage", 42, 95, "OOO Base №1", "Vegetables", new List<string>() { "branch1", "branch2", "branch3" }));
            //admin1.AddProductToDatabase(new Product("Carrot", 55, 105, "OOO Base №1", "Vegetables", new List<string>() { "branch1", "branch2", "branch3" }));
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.FindAdmin("Sidor", "Sidorov");

            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));
            //  Доработать текущий код, чтобы если такого клиента нет в бд -  клиент добавлялся, а если есть - обновлялся. 


        }
    }
}
