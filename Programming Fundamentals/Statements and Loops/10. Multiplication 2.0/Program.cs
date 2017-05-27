using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            for (int i = num2; i <= 10; i++)
            {
                Console.WriteLine($"{num1} X {i} = {num1 * i}");
            }

            if (num2>10)
                Console.WriteLine($"{num1} X {num2} = {num1 * num2}");

        }
    }
}
