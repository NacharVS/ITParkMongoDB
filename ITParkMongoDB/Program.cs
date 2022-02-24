using System;using System.Collections.Generic;

namespace ITParkMongoDB
{
    public class Program
    {
         static void Main(string[] args)
        {
            Administrator admin1 = new Administrator("Maria", "Dmitrieva", "Administrator", 14012012, "Higher");
            Client client = new Client("Dasha");
            DataBase.AddClientToDataBase(client);
            Client.ClientsLog(client);
            var cart = new Cart();

            //admin1.UpdateClubCartPlatinum("Dasha");

            ////client.BuyingProduct("Carpaccio", "Meat gastronomy", 3);
            client.BuyingProduct("Curd cheese", "Cheese", 10);
            DataBase.GetCart("Dasha");
            Client.ClientsLog(client);
             










            //admin1.UpdateNameClient("Boris", "Dasha");

            //admin1.AddProductToDataBase(new Product("Curd cheese", 250, 40, "EcoMilk", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Processed cheese", 250, 30, "Hochland", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Mozzarella cheese", 180, 50, "Galbani", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Parmesan cheese", 200, 40, "Solemici", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Camembert cheese", 300, 20, "President", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));

            //admin1.AddProductToDataBase(new Product("Carpaccio", 150, 20, "Pava-Pava", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Bacon", 265, 30, "Velcom", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Jamon", 350, 20, "DeLion", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Sausage", 200, 40, "Solemici", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Sausages", 140, 30, "HitMeat", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));

            //admin1.AddProductToDataBase(new Product("Toothpaste", 245, 48, "R.O.C.S.", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Soap", 100, 30, "Dove", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Shampoo", 300, 40, "Gliss Kur", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Hair balm", 309, 80, "Gliss Kur", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Deodorant", 200, 30, "Nivea", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));

            //admin1.AddProductToDataBase(new Product("Pasta", 70, 100, "Barilla", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Buckwheat", 120, 30, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Rice", 111, 40, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Muesli", 130, 50, "Matti", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Flour", 78, 20, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));

            //admin1.AddProductToDataBase(new Product("Сhocolate", 100, 60, "Milka", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Candy", 350, 50, "Raffaello", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Nut paste", 420, 30, "Nutella", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Croissants", 150, 40, "7Days", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            //admin1.AddProductToDataBase(new Product("Coocie", 144, 20, "Oreo", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));

           



        }
    }
}
