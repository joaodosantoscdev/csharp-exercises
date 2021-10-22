using csharp_exercises_4.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace csharp_exercises_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            
            for ( int i = 1; i <= n; i++ )
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported? (c/u/i) : ");
                char c = char.Parse(Console.ReadLine());
                Console.Write("Name :");
                string name = Console.ReadLine();
                Console.Write("Price :");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (c == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (c == 'u')
                {
                    Console.WriteLine("Manufacture date (dd/MM/yyyy) : ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                } 
                else
                {
                    Console.WriteLine("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE-TAGS :");
            foreach (Product p in list)
            {
                Console.WriteLine(p.PriceTag());
            }
        }
    }
}
