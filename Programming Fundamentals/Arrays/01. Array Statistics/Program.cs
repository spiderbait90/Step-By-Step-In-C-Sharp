using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            PrintMin(numbers);
            PrintMax(numbers);
            PrintSum(numbers);
            PrintAverage(numbers);
        }

        private static void PrintAverage(int[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            sum /= numbers.Length;
            Console.WriteLine("Average = " + sum);
        }

        static void PrintSum(int[] numbers)
        {
            long sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum = " + sum);
        }

        static void PrintMax(int[] numbers)
        {
            var max = long.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }
            Console.WriteLine("Max = " + max);
        }

        static void PrintMin(int[] numbers)
        {
            var min = long.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine("Min = "+min);
        }
    }
}
