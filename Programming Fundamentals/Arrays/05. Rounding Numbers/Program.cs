using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rounding_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} => ");
                var rounded = Math.Round(numbers[i], MidpointRounding.AwayFromZero);
                Console.WriteLine(rounded);
            }
        }
    }
}
