using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Occurrences_of_____
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var p = double.Parse(Console.ReadLine());

            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                    count++;
            }
            Console.WriteLine(count);

        }
    }
}
