using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_exercises_10
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Enter the full file path: ");
            string sourcePath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                Dictionary<string, int> dictionary = new Dictionary<string, int>();

                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    while (!sr.EndOfStream) 
                    {
                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine($"{item.Key}, {item.Value}");
                    }
                }
            } catch (IOException e) 
            {
                Console.WriteLine("An error ocurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
