using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var check = "";
            var combinations = 0;
            for (int a = num1; a <= num2; a++)
            {
                for (int b = num1; b <= num2; b++)
                {
                    if (a + b == magicNumber)
                        check = $"{a} + {b} = {a + b}";
                    combinations++;
                }
            }

            if (check=="")
            {
                Console.WriteLine($"{combinations} combinations " +
                    $"- neither equals {magicNumber}");
            }
            else
                Console.WriteLine($"Number found! {check}");
        }
    }
}
