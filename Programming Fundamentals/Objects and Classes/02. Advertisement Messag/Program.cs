using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Messag
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[] phrases = { "Excellent product.", "Such a great product."
                    , "I always use that product.", "Best product of its category."
                    , "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles.I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya"
                    , "Iva", "Annie", "Eva"};
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var rnd1 = new Random(); var rnd2 = new Random();
            var rnd3 = new Random(); var rnd4 = new Random();
            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine($"{phrases[rnd1.Next(phrases.Length)]}" +
                    $" {events[rnd2.Next(events.Length)]} " +
                    $"{authors[rnd3.Next(authors.Length)]} - " +
                    $"{cities[rnd3.Next(cities.Length)]}");
            }
        }
    }
}
