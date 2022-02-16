using System;
using System.Collections.Generic;

namespace ITParkMongoDB
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseMethods.ShowProductsInCategory("food");
            DataBaseMethods.ShowProductsInCategory("cosmetic");

            Client client1 = new Client("Maria", "Petrova");
            //DataBaseMethods.AddClientToDatabase(client1);
            //client1.BuyProduct("coffee", "food", 4);
            client1.BuyProduct("coffee", "food", 2);
            client1.BuyProduct("soap", "cosmetic", 2);

            Console.WriteLine();
            DataBaseMethods.ShowProductsInCategory("food");
            DataBaseMethods.ShowProductsInCategory("cosmetic");

            //DataBaseMethods.ReplaceAdmin("Sergey", new Administrator("Sergey", "Ivanov", "Administrator", 987654, "High"));
            //Administrator admin1 = new Administrator("Ivan", "Ivanov", "Administrator");
            //DataBaseMethods.AddAdminToDatabase(admin1);
            //DataBaseMethods.AddMerchToDatabase(new Mechendaiser("Petr", "Petrov", "Pelikan", "Merchendaizer", "middle"));

            //admin1.AddProductToDatabase(new Product("bread", 32, 10, "Krymhleb", "food", new List<string> { "Caspiy", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("butter", 160, 10, "Sakskoe", "food", new List<string> { "Caspiy", "Beztsen" }));
            //admin1.AddProductToDatabase(new Product("orange", 120, 8, "Egypt", "food", new List<string> { "Silpo", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("milk", 64, 10, "Sakskoe", "food", new List<string> { "Caspiy", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("coffee", 355, 5, "Tasty Coffe", "food", new List<string> { "Silpo", "PUD" }));

            //admin1.AddProductToDatabase(new Product("shampoo", 320, 10, "Alerana", "cosmetic", new List<string> { "Caspiy", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("shampoo", 630, 10, "Diapason Cosmetics", "cosmetic", new List<string> { "Caspiy", "Beztsen" }));
            //admin1.AddProductToDatabase(new Product("soap", 380, 5, "Aleppo", "cosmetic", new List<string> { "Caspiy" }));
            //admin1.AddProductToDatabase(new Product("hair oil", 550, 10, "East Night", "cosmetic", new List<string> { "Caspiy", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("soap", 25, 10, "Ushasty Njan", "cosmetic", new List<string> { "Silpo", "PUD" }));

            //admin1.AddProductToDatabase(new Product("10 negritos", 210, 3, "Agatha Cristie", "books", new List<string> { "Knizhny", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("Rikki-Tikki-Tavi", 370, 1, "R.Kipling", "books", new List<string> { "Knizhny" }));
            //admin1.AddProductToDatabase(new Product("The little prince", 643, 8, "A. de Saint-Exupery", "books", new List<string> { "Silpo", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("Jane Eyre", 244, 3, "Ch.Bronte", "books", new List<string> { "Knizhny", "Beztsen", "PUD" }));
            //admin1.AddProductToDatabase(new Product("Trejos Tacos", 365, 2, "D.Trejo", "books", new List<string> { "Silpo", "PUD" }));

            //admin1.AddProductToDatabase(new Product("aspirine", 39, 10, "Farm", "medical", new List<string> { "Aprel", "Apteka", "PUD" }));
            //admin1.AddProductToDatabase(new Product("vata", 280, 5, "Zig-Zag", "medical", new List<string> { "Aprel", "Apteka" }));
            //admin1.AddProductToDatabase(new Product("spasmalgon", 78, 8, "Farm", "medical", new List<string> { "Silpo", "Apteka", "PUD" }));
            //admin1.AddProductToDatabase(new Product("spirit", 105, 10, "Septiko", "medical", new List<string> { "Aprel", "Apteka", "PUD" }));
            //admin1.AddProductToDatabase(new Product("patch", 96, 5, "Septiko", "medical", new List<string> { "Silpo", "PUD" }));


            //1. Добавить по 5 товаров в разные категории(всего 4 категории)
            //2. Реализовать класс Client и в нём, реализовать метод покупки товара, с условием,
            //   что на складе(в базе данных) товар уменьшается после покупки.
            // 


        }
    }
}
