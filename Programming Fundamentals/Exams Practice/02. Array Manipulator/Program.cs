using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var input = Console.ReadLine();
            while (input != "end")
            {
                var split = input.Split();
                var command = split[0];

                if (command == "exchange")
                {
                    var index = int.Parse(split[1]);
                    if (index > numbers.Length - 1 || index < 0)
                        Console.WriteLine("Invalid index");
                    else
                    {
                        numbers = Exchange(numbers, index);
                    }
                }
                else if (split.Length == 2)
                {
                    var oddOrEven = split[1];
                    MaxOrMin(numbers, command, oddOrEven);
                }
                else if (split.Length == 3)
                {
                    var count = int.Parse(split[1]);
                    var oddOrEven = split[2];
                    firstOrLast(numbers, count, oddOrEven, command);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void firstOrLast(int[] numbers, int count, string oddOrEven, string command)
        {
            var result = numbers;
            if (count > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (command == "first")
            {
                if (oddOrEven == "odd")
                {
                    result = numbers.Where(x => x % 2 != 0)
                        .Take(count).ToArray();
                }
                else
                {
                    result = numbers.Where(x => x % 2 == 0)
                        .Take(count).ToArray();
                }
            }
            else if (command == "last")
            {
                if (oddOrEven == "odd")
                {
                    result = numbers.Where(x => x % 2 != 0)
                       .ToArray();
                    result = result.Skip(result.Length - count).Take(count)
                        .ToArray();
                }
                else
                {
                    result = numbers.Where(x => x % 2 == 0)
                        .ToArray();
                    result = result.Skip(result.Length - count).Take(count)
                        .ToArray();
                }
            }
            Console.WriteLine("["+string.Join(", ",result)+"]");
        }

        private static void MaxOrMin(int[] numbers, string command, string oddOrEven)
        {
            int index = -1;
            int result = -1;
            if (command == "max")
            {
                if (oddOrEven == "odd")
                {
                    result = numbers.Where(x => x % 2 != 0).DefaultIfEmpty(-1).Max();
                    index = numbers.ToList().LastIndexOf(result);
                }
                else
                {
                    result = numbers.Where(x => x % 2 == 0).DefaultIfEmpty(-1).Max();
                    index = numbers.ToList().LastIndexOf(result);
                }
            }
            else if (command == "min")
            {
                if (oddOrEven == "odd")
                {
                    result = numbers.Where(x => x % 2 != 0).DefaultIfEmpty(-1).Min();
                    index = numbers.ToList().LastIndexOf(result);
                }
                else
                {
                    result = numbers.Where(x => x % 2 == 0).DefaultIfEmpty(-1).Min();
                    index = numbers.ToList().LastIndexOf(result);
                }
            }
            if (result != -1)
                Console.WriteLine(index);
            else
                Console.WriteLine("No matches");
        }

        private static int[] Exchange(int[] numbers, int index)
        {
            var right = numbers.Skip(index + 1).Take(numbers.Length).ToArray();
            var left = numbers.Take(index + 1).ToArray();
            return right.Concat(left).ToArray();
        }
    }
}
