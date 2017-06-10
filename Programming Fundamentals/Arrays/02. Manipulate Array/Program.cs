using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split();

                if (command[0]=="Distinct")
                {
                    input = Distinct(input).ToArray();
                }
                else if (command[0]=="Reverse")
                {
                    input = Reverse(input);
                }
                else if (command[0]=="Replace")
                {
                    input[int.Parse(command[1])] = command[2];
                }
            }
            Console.WriteLine(string.Join(", ",input));
        }  

        static string[] Reverse(string[] input)
        {
            for (int i = 0; i < input.Length/2; i++)
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
