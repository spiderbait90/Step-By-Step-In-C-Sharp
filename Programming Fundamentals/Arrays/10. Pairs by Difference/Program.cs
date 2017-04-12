using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var diff = int.Parse(Console.ReadLine());
            var count = 0;
            for (int a = 0; a < numbers.Length; a++)
            {
                for (int b = 0; b < numbers.Length; b++)
                {
                    if (numbers[a] + diff == numbers[b])
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
