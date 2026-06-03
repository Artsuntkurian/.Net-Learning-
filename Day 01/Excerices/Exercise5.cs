using System;
using System.Collections.Generic;

class Exercise5
{
    public static void Run()
    {
        Dictionary<string, double> products = new Dictionary<string, double>();

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"Enter Product {i} Name: ");
            string name = Console.ReadLine() ?? string.Empty;

            Console.Write($"Enter Product {i} Price: ");
            string priceInput = Console.ReadLine() ?? string.Empty;
            double price;
            while (!double.TryParse(priceInput, out price))
            {
                Console.Write("Invalid price. Enter a valid number: ");
                priceInput = Console.ReadLine() ?? string.Empty;
            }

            products.Add(name, price);
        }

        Console.WriteLine("\nProducts:");

        foreach (var product in products)
        {
            Console.WriteLine($"Name: {product.Key}, Price: {product.Value}");
        }
    }
}