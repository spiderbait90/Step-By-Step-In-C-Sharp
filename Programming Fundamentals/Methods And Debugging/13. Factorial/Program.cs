using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            BigInteger zero = 0;
            var count = 0;
            while(zero==0)
            {
                zero = fact % 10;
                fact /= 10;
                if (zero == 0)
                    count++;
            }
            Console.WriteLine(count);
        }
        static BigInteger
    }
}
