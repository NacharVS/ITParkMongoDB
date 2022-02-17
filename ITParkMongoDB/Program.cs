using System;using System.Collections.Generic;

namespace ITParkMongoDB
{
    public class Program
    {
         static void Main(string[] args)
        {
            Administrator admin1 = new Administrator("Maria", "Dmitrieva", "Administrator", 14012012, "Higher");
            DataBase.AddAdministratorToDataBase(admin1);

            admin1.AddProductToDataBase(new Product("Curd cheese", 250, 40, "EcoMilk", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Processed cheese", 250, 30, "Hochland", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Mozzarella cheese", 180, 50, "Galbani", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Parmesan cheese", 200, 40, "Solemici", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Camembert cheese", 300, 20, "President", "Cheese", new List<string> { "Pelican", "Persten", "Medovik" }));

            admin1.AddProductToDataBase(new Product("Carpaccio", 150, 20, "Pava-Pava", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Bacon", 265, 30, "Velcom", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Jamon", 350, 20, "DeLion", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Sausage", 200, 40, "Solemici", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Sausages", 140, 30, "HitMeat", "Meat gastronomy", new List<string> { "Pelican", "Persten", "Medovik" }));

            admin1.AddProductToDataBase(new Product("Toothpaste", 245, 48, "R.O.C.S.", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Soap", 100, 30, "Dove", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Shampoo", 300, 40, "Gliss Kur", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Hair balm", 309, 80, "Gliss Kur", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Deodorant", 200, 30, "Nivea", "Cosmetics and hygiene", new List<string> { "Pelican", "Persten", "Medovik" }));

            admin1.AddProductToDataBase(new Product("Pasta", 70, 100, "Barilla", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Buckwheat", 120, 30, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Rice", 111, 40, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Muesli", 130, 50, "Matti", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Flour", 78, 20, "MAKFA", "Grocery", new List<string> { "Pelican", "Persten", "Medovik" }));

            admin1.AddProductToDataBase(new Product("Сhocolate", 100, 60, "Milka", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Candy", 350, 50, "Raffaello", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Nut paste", 420, 30, "Nutella", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Croissants", 150, 40, "7Days", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));
            admin1.AddProductToDataBase(new Product("Coocie", 144, 20, "Oreo", "Sweets", new List<string> { "Pelican", "Persten", "Medovik" }));

            Client client = new("Дарья", "Захарова");
            Console.WriteLine($"Добрый день!");
            while (true)
            {
                Console.WriteLine("Каталог категорий товаров:\n 1.Cheese \n 2.Meat gastronomy\n 3.Grocery\n 4.Sweets\n 5.Cosmetics and hygiene");
                Console.WriteLine("Введите название категории, для просмотра товаров");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "Cheese":
                        var list = DataBase.ShowProductInCategory("Cheese");
                        Console.WriteLine($"Вид товара:   Производитель:   Стоимость:");
                        foreach (var item in list)
                        {
                            Console.WriteLine($"{item.NameOfProduct}   {item.Manufacturer}   {item.Price}");
                        }
                        Console.WriteLine("Выберите дальнейшее действие: ");
                        Console.WriteLine("Выбор товара для покупки в этой категории. Нажмите: 0");
                        Console.WriteLine("Или вы хотите просмотреть другую категорию товаров? Нажмите:  1");
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 == 0)
                        {
                            Console.Write("Введите название продукта: ");
                            string nameproduct = Console.ReadLine();
                            DataBase.FindProductinCheese(nameproduct);
                            Console.Write("Введите количество товара: ");
                            int countAtWarehouse = int.Parse(Console.ReadLine());
                            client.BuyingProduct(nameproduct, countAtWarehouse);
                            // DataBase.ReplaceProductCheese(nameproduct, new Product());

                        }
                        break;
                    case "Meat gastronomy":
                        var list2 = DataBase.ShowProductInCategory("Meat gastronomy");
                        Console.WriteLine($"Вид товара:   Производитель:   Стоимость:");
                        foreach (var item in list2)
                        {
                            Console.WriteLine($"{item.NameOfProduct}   {item.Manufacturer}   {item.Price}");
                        }
                        Console.WriteLine("Выберите дальнейшее действие: ");
                        Console.WriteLine("Выбор товара для покупки в этой категории. Нажмите: 0");
                        Console.WriteLine("Или вы хотите просмотреть другую категорию товаров? Нажмите:  1");
                        int choice3 = int.Parse(Console.ReadLine());
                        if (choice3 == 0)
                        {
                            Console.Write("Введите название продукта: ");
                            string nameproduct = Console.ReadLine();
                            DataBase.FindProductinMeatGastronomy(nameproduct);
                            Console.Write("Введите количество товара: ");
                            int countAtWarehouse = int.Parse(Console.ReadLine());
                            client.BuyingProduct(nameproduct, countAtWarehouse);
                            // DataBase.ReplaceProductCheese();

                        }
                        break;
                    case "Grocery":
                        var list3 = DataBase.ShowProductInCategory("Grocery");
                        Console.WriteLine($"Вид товара:   Производитель:   Стоимость:");
                        foreach (var item in list3)
                        {
                            Console.WriteLine($"{item.NameOfProduct}   {item.Manufacturer}   {item.Price}");
                        }
                        Console.WriteLine("Выберите дальнейшее действие: ");
                        Console.WriteLine("Выбор товара для покупки в этой категории. Нажмите: 0");
                        Console.WriteLine("Или вы хотите просмотреть другую категорию товаров? Нажмите:  1");
                        int choice4 = int.Parse(Console.ReadLine());
                        if (choice4 == 0)
                        {
                            Console.Write("Введите название продукта: ");
                            string nameproduct = Console.ReadLine();
                            DataBase.FindProductinGrocery(nameproduct);
                            Console.Write("Введите количество товара: ");
                            int countAtWarehouse = int.Parse(Console.ReadLine());
                            client.BuyingProduct(nameproduct, countAtWarehouse);
                            // DataBase.ReplaceProductCheese(nameproduct,);

                        }
                        break;
                    case "Sweets":
                        var list4 = DataBase.ShowProductInCategory("Sweets");
                        Console.WriteLine($"Вид товара:   Производитель:   Стоимость:");
                        foreach (var item in list4)
                        {
                            Console.WriteLine($"{item.NameOfProduct}   {item.Manufacturer}   {item.Price}");
                        }
                        Console.WriteLine("Выберите дальнейшее действие: ");
                        Console.WriteLine("Выбор товара для покупки в этой категории. Нажмите: 0");
                        Console.WriteLine("Или вы хотите просмотреть другую категорию товаров? Нажмите:  1");
                        int choice5 = int.Parse(Console.ReadLine());
                        if (choice5 == 0)
                        {
                            Console.Write("Введите название продукта: ");
                            string nameproduct = Console.ReadLine();
                            DataBase.FindProductinSweets(nameproduct);
                            Console.Write("Введите количество товара: ");
                            int countAtWarehouse = int.Parse(Console.ReadLine());
                            client.BuyingProduct(nameproduct, countAtWarehouse);
                            // DataBase.ReplaceProductSweets();

                        }
                        break;
                    case "Cosmetics and hygiene":
                        var list5 = DataBase.ShowProductInCategory("Cosmetics and hygiene");
                        Console.WriteLine($"Вид товара:   Производитель:   Стоимость:");
                        foreach (var item in list5)
                        {
                            Console.WriteLine($"{item.NameOfProduct}   {item.Manufacturer}   {item.Price}");
                        }
                        Console.WriteLine("Выберите дальнейшее действие: ");
                        Console.WriteLine("Выбор товара для покупки в этой категории. Нажмите: 0");
                        Console.WriteLine("Или вы хотите просмотреть другую категорию товаров? Нажмите:  1");
                        int choice6 = int.Parse(Console.ReadLine());
                        if (choice6 == 0)
                        {
                            Console.Write("Введите название продукта: ");
                            string nameproduct = Console.ReadLine();
                            DataBase.FindProductinCosmeticsHygiene(nameproduct);
                            Console.Write("Введите количество товара: ");
                            int countAtWarehouse = int.Parse(Console.ReadLine());
                            client.BuyingProduct(nameproduct, countAtWarehouse);
                            // DataBase.ReplaceProductCosmeticsHygiene();
                        }
                        break;
                }
                Console.WriteLine("Вы хотите продолжить выбор товаров? Нажмите - 0");
                Console.WriteLine("Или завершить выбор товаров? Нажмите - 1");
                int choice7 = int.Parse(Console.ReadLine());
                if (choice7 == 1)
                    break;
            }
            Console.WriteLine($"Оплата товаров в вашей корзине");

            






        }
    }
}
