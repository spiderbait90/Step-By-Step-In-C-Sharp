using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(long.Parse).ToList();
            var index = int.Parse(Console.ReadLine());

            var command1 = Console.ReadLine();
            var command2 = Console.ReadLine();

            if (command1 == "cheap")
            {
                switch (command2)
                {
                    case "positive": SumPositiveCheap(numbers, index); break;
                    case "negative": SumNegativeCheap(numbers, index); break;
                    case "all": SumAllCheap(numbers, index); break;
                }
            }
            else
            {
                switch (command2)
                {
                    case "positive": SumPositiveExpensive(numbers, index); break;
                    case "negative": SumNegativeExpensive(numbers, index); break;
                    case "all": SumAllEspensive(numbers, index); break;
                }
            }
        }
        public static void SumAllEspensive(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x >= numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x >= numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void SumNegativeExpensive(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x < 0 && x >= numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x < 0 && x >= numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void SumPositiveExpensive(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x > 0 && x >= numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x > 0 && x >= numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void SumAllCheap(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x < numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x < numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void SumNegativeCheap(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x < 0 && x < numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x < 0 && x < numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void SumPositiveCheap(List<long> numbers, int index)
        {
            var left = numbers.Where((x, i) => x > 0 && x < numbers[index] && i < index).Sum();
            var right = numbers.Where((x, i) => x > 0 && x < numbers[index] && i > index).Sum();
            LeftOrRight(left, right);
        }

        public static void LeftOrRight(long left, long right)
        {
            if (left >= right)
                Console.WriteLine($"Left - {left}");
            else
                Console.WriteLine($"Right - {right}");
        }
    }
}