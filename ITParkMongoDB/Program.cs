using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {

            //Administrator admin1 = new Administrator("Ivan", "Ivanov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));
            //admin1.AddProductToDatabase(new Product("Bread", 30, 80, "ChelnyKhleb", "Food", new List<string> { "Pelikan", "Persten", "Medovik" }));
            //admin1.AddProductToDatabase(new Product("Butter", 120, 50, "Vamin", "Food", new List<string> { "Pelikan", "Persten", "Samobranka" }));
            //admin1.AddProductToDatabase(new Product("Shampoo", 300, 60, "P&G", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Aspirine", 30, 120, "Farm", "Medical", new List<string> { "Apteka", "Box", "Znakhar" }));
            Client client = new Client();
            client.Buy("Bread", "Food", 50);
            client.ShowCart();
            
            //1. Добавить по 5 товаров в разные категории(всего 4 категории)
            //2. Реализовать класс Client и в нём, реализовать метод покупки товара, с условием,
            //   что на складе(в базе данных) товар уменьшается после покупки.
            // 
            

        }
    }
}
