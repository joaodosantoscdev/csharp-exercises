using System;
using System.Collections.Generic;

namespace csharp_exercises_9
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();

            Console.Write("How many students for course A ?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++ )
            {
                int student = int.Parse(Console.ReadLine());
                a.Add(student);
            }


            Console.Write("How many students for course B ?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                b.Add(student);
            }


            Console.Write("How many students for course C ?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                c.Add(student);
            }

            HashSet<int> all = new HashSet<int>(a);
            all.UnionWith(b);
            all.UnionWith(c);

            Console.Write("Total students: ");
            Console.Write(all.Count);
        }
    }
}
