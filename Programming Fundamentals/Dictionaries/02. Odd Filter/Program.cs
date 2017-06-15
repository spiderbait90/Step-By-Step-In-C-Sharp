using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers.Average())
                    numbers[i] += 1;
                else
                    numbers[i] -= 1;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
