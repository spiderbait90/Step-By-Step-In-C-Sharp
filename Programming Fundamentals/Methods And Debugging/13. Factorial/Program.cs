using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());

            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            var countZero = 0;

            while (true)
            {
                var digit = result % 10;
                if (digit == 0)
                    countZero++;
                else
                    break;
                result /= 10;
            }
            Console.WriteLine(countZero);
        }        
    }
}
