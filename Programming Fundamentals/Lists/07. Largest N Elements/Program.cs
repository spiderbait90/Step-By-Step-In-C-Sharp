using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Largest_N_Elements
{
    class Program
    {
        static void Main(string[] args)
        {           

            var numbers = Console.ReadLine().Split()
               .Select(int.Parse)
               .ToArray();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i]<numbers[i+1])
                {
                    var temp = numbers[i];
                    numbers[i] = numbers[i + 1];
                    numbers[i + 1] = temp;
                    i = -1;

                }
            }
            Console.WriteLine(string.Join(" ",numbers.Take(n)));
        }
    }
}
