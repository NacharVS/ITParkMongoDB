using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Administrator.AddClubCardClassik("Oleg");
            Administrator.AddClubCardVIP("Grisha");
            //DataBaseMethods.AddProductToDatabase(new Product("Tomato", 200, 90, "Egoryevskie Teplici", "Food", new List<string>() { "bbb, qqq, zzz"}));
            //Client client = new Client("Grisha");
            ////DataBaseMethods.UpdateSomething("Food", "Tomato", 10);
            //DataBaseMethods.AddToCliensCart();

            //client.Buy("Bread", "Bakery", 5);
            //client.Buy("J7", "Juices and water", 5);
            //client.Buy("Butter", "Milk products", 5);
            //Client.ClientsLog(client);
            //client.ShowCart();


            //DataBaseMethods.Shopping("Baguette", new Product("Bagguette", 30, 40, "Bahetle", "Bakery", new List<string> { "Pelikan", "Persten", "Pekar'" }));


            //start

            //DataBaseMethods.ReplaceAdmin("Sergey", new Administrator("Sergey", "Ivanov", "Administrator", 987654, "High"));
            //Administrator admin1 = new Administrator("Fedor", "Fedorov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            ////DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));



            ////Bakery
            //admin1.AddProductToDatabase(new Product("Bread", 50, 80, "ChelnyKhleb", "Food", new List<string> { "Pelikan", "Persten", "Medovik" }));
            //admin1.AddProductToDatabase(new Product("Bun", 20, 100, "3 KhlebZavod", "Food", new List<string> { "Pelikan", "Persten", "Samobranka" }));
            //admin1.AddProductToDatabase(new Product("Baguette", 30, 50, "Bahetle", "Food", new List<string> { "Pelikan", "Persten", "Pekar'" }));
            //admin1.AddProductToDatabase(new Product("Cookies", 120, 150, "Kuhmaster", "Food", new List<string> { "Pelikan", "Persten", "Pestrechinka" }));
            //admin1.AddProductToDatabase(new Product("Pita", 30, 30, "Kebab", "Food", new List<string> { "Lavka", "Magomed", "Habib" }));
            ////Milk products
            //admin1.AddProductToDatabase(new Product("Kefir", 45, 40, "Prostomoloko", "Food", new List<string> { "Pelikan", "Persten", "VeselyMolochnik" }));
            //admin1.AddProductToDatabase(new Product("Butter", 120, 35, "Vamin", "Food", new List<string> { "Pelikan", "Persten", "VeselyMolochnik" }));
            //admin1.AddProductToDatabase(new Product("Milk", 60, 50, "Vamin", "Food", new List<string> { "Pelikan", "Persten", "VeselyMolochnik" }));
            //admin1.AddProductToDatabase(new Product("Sour cream", 50, 20, "SeloZelenoe", "Food", new List<string> { "Pelikan", "Persten", "SeloZelenoe" }));
            //admin1.AddProductToDatabase(new Product("Сheese", 150, 60, "Alekseevskoe", "Food", new List<string> { "Pelikan", "Persten", "Mamadish" }));
            ////Juices and water
            //admin1.AddProductToDatabase(new Product("Coca-cola", 50, 100, "Coca-Cola Company", "Juices and water", new List<string> { "Red", "Hot", "Chili Peppers" }));
            //admin1.AddProductToDatabase(new Product("Pepsi", 50, 80, "PepsiCo", "Juices and water", new List<string> { "Blue", "Cold", "Winter" }));
            //admin1.AddProductToDatabase(new Product("MIrinda", 50, 80, "PepsiCo", "Juices and water", new List<string> { "Blue", "Cold", "Winter" }));
            //admin1.AddProductToDatabase(new Product("Bonaqua", 40, 100, "Coca-Cola Company", "Juices and water", new List<string> { "Red", "Hot", "Chili Peppers" }));
            //admin1.AddProductToDatabase(new Product("J7", 90, 80, "PepsiCo", "Juices and water", new List<string> { "Blue", "Cold", "Winter" }));
            ////Cosmetic
            //admin1.AddProductToDatabase(new Product("Shampoo", 300, 60, "P&G", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Soap", 50, 100, "P&G", "Colgate-Palmolive", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Toothpaste", 150, 150, "Colgate-Palmolive", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Deodorant", 250, 120, "Rexona", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Perfume", 1000, 20, "D&G", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            ////Medical
            //admin1.AddProductToDatabase(new Product("Aspirine", 200, 120, "Farm", "Medical", new List<string> { "Uliza", "Fonar'", "Apteka" }));
            //admin1.AddProductToDatabase(new Product("Paracitomol", 70, 120, "Farm", "Medical", new List<string> { "Uliza", "Fonar'", "Apteka" }));
            //admin1.AddProductToDatabase(new Product("Activated carbon", 50, 120, "Farm", "Medical", new List<string> { "Uliza", "Fonar'", "Apteka" }));
            //admin1.AddProductToDatabase(new Product("Suprastin", 100, 120, "Farm", "Medical", new List<string> { "Apteka", "Box", "Znakhar" }));

        }
    }
}
