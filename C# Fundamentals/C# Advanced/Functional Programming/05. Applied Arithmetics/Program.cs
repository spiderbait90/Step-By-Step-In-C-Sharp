using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                    break;

                if (command == "add")
                {
                    numbers = numbers.Select(x => x + 1).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(x => x * 2).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(x => x - 1).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }

        }
    }
}
