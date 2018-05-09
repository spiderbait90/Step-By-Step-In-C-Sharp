using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var type = Console.ReadLine();

            Print(type,range);
        }

        static void Print(string type, int[] range)
        {
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (type == "odd" && i % 2 != 0)
                    Console.Write(i + " ");
                else if (type == "even" && i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
