using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_num
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var maxCount = 1;
            var currentCount = 1;
            int digit = numbers[0];
            
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentCount++;
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        digit = numbers[i];
                    }
                }
                else
                    currentCount = 1;
            }
            var result = new int[maxCount];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = digit;
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
