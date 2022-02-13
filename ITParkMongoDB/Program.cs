using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = DataBaseMethods.ShowProductsInCategory("Food");
            foreach (var item in list)
            {
                Console.WriteLine($"{item.NameOfProduct} {item.Manufacturer} {item.Price} {item.ListOfFillials[0]}");
            }
            //Administrator admin1 = new Administrator();
            //admin1.AddProductToDatabase(new Product("Bread", 30, 80, "ChelnyKhleb", "Food", new List<string> {"Pelikan", "Persten", "Medovik" }));
            //admin1.AddProductToDatabase(new Product("Butter", 120, 50, "Vamin", "Food", new List<string> { "Pelikan", "Persten", "Samobranka" }));
            //admin1.AddProductToDatabase(new Product("Shampoo", 300, 60, "P&G", "Cosmetic", new List<string> { "Botinok", "Shkaf", "Korobka" }));
            //admin1.AddProductToDatabase(new Product("Aspirine", 30, 120, "Farm", "Medical", new List<string> { "Apteka", "Box", "Znakhar" }));

        }
    }
}
