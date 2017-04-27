using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.Big_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger number = 1;

            for (int i = 1; i <= n; i++)
            {
                number *= i;
            }
            Console.WriteLine(number);
        }
    }
}
