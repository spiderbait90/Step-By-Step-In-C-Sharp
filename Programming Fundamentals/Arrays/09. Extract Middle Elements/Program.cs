using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Extract(n);
        }

        private static void Extract(int[] n)
        {

            if (n.Length == 1)
            {
                Console.WriteLine("{ " + $"{n[0]}" + " }");
            }
            else if (n.Length % 2 == 0)
            {
                Console.WriteLine($"{n[n.Length / 2 - 1]}," +
                    $" {n[n.Length / 2]}");
                    
            }
            else if (n.Length % 2 != 0)
            {
                Console.WriteLine($"{n[n.Length / 2 - 1]}," +
                    $" {n[n.Length / 2]}," +
                    $" {n[n.Length / 2 + 1]}");
            }
        }


    }
}
