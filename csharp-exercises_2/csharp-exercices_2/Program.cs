using System;
using csharp_exercices_2.Entities;

namespace csharp_exercices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip!.");
            Comment c2 = new Comment("Wow! That's awesome!!!.");
            Post p1 = new Post(
                DateTime.Parse("21/06/2021 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!.",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night !!!.");
            Comment c4 = new Comment("May the Force be with uu.");
            Post p2 = new Post(
                DateTime.Parse("28/07/2021 23:14:30"),
                "Good night guys",
                "See u tomorrow!.",
                5);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
