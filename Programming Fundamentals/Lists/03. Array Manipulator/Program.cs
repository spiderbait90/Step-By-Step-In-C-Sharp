using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Array_Manipulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();
            while (input != "print")
            {
                var command = input.Split();
                if (command[0] == "add")
                {
                    numbers.Insert
                        (int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "addMany")
                {
                    numbers.InsertRange
                        (int.Parse(command[1]), command.Skip(2).Select(int.Parse));
                }
                else if (command[0] == "contains")
                {
                    Console.WriteLine
                        (numbers.IndexOf(int.Parse(command[1])));
                }
                else if (command[0] == "remove")
                {
                    numbers.RemoveAt
                        (int.Parse(command[1]));
                }
                else if (command[0] == "shift")
                {
                    numbers = ShiftLeft(command[1], numbers);
                }
                else if (command[0] == "sumPairs")
                {
                    numbers = SumPairs(numbers);
                }
                ///Console.WriteLine(string.Join(" ",numbers));
                input = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        public static List<int> SumPairs(List<int> numbers)
        {
            var result = new List<int>();
            for (int i = 0; i < numbers.Count - 1; i+=2)
            {
                result.Add(numbers[i] + numbers[i + 1]);
            }
            if (numbers.Count % 2 != 0)
            {
                result.Add(numbers[numbers.Count - 1]);
            }
            return result;
        }

        public static List<int> ShiftLeft(string p, List<int> numbers)
        {
            var times = int.Parse(p);
            for (int a = 0; a < times; a++)
            {
                var temp = numbers[0];
                for (int b = 0; b < numbers.Count - 1; b++)
                {
                    numbers[b] = numbers[b + 1];
                }
                numbers[numbers.Count - 1] = temp;
            }
            return numbers;
        }
    }
}
