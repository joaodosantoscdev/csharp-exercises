using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace csharp_exercise_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path file :");
            string path = Console.ReadLine();
            Console.WriteLine("Enter the salary: ");
            double salaryInput = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employees = new List<Employee>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(",");
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        employees.Add(new Employee(name, email, salary));
                    }
                }



                var emails = employees.Where(e => e.Salary > salaryInput).OrderBy(e => e.Email).Select(obj => obj.Email);

                var sum = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Console.WriteLine($"Emails with salary above {salaryInput.ToString("F2", CultureInfo.InvariantCulture)}: ");
                foreach (string email in emails)
                {
                    Console.WriteLine(email);
                }

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error has occurred!");
                Console.WriteLine(e.Message);
            }


        }
    }
}
