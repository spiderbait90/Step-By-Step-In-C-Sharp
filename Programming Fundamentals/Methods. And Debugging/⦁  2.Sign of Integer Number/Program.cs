using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sign_of_Integer_Number
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Result(n);
        }
        static void Result(int numberN)
        {
            if (numberN > 0)
                Console.WriteLine($"The number {numberN} is positive.");
            else if (numberN < 0)
                Console.WriteLine($"The number {numberN} is negative.");
            else
                Console.WriteLine($"The number {numberN} is zero.");
        }
    }
}
