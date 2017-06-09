using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            while (true)
            {
                var command = Console.ReadLine().Split();

                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Distinct")
                {
                    input = Distinct(input).ToArray();
                }
                else if (command[0] == "Reverse")
                {
                    input = Reverse(input);
                }
                else if (command[0] == "Replace")
                {
                    var index = int.Parse(command[1]);
                    if (index < input.Length && index >= 0)
                        input[index] = command[2];
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            Console.WriteLine(string.Join(", ", input));
        }

        static string[] Reverse(string[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                var temp = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = temp;
            }
            return input;
        }

        static HashSet<string> Distinct(string[] input)
        {
            var unique = new HashSet<string>();
            for (int a = 0; a < input.Length; a++)
            {
                unique.Add(input[a]);
            }
            return unique;
        }
    }
}
