using csharp_exercises_7.Entities;
using System;
using System.Globalization;
using System.IO;

namespace csharp_exercises_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string sourcePathFile = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcePathFile);

                string InputDirectory = Path.GetDirectoryName(sourcePathFile);
                string OutputDirectory = InputDirectory + @"\out";
                string OutputFile = OutputDirectory + @"\sumary.csv";

                Directory.CreateDirectory(OutputDirectory);

                using (StreamWriter sw = File.AppendText(OutputFile))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product p = new Product(name, price, quantity);

                        sw.WriteLine($"{p.Name}, {p.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                }  
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error has ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
