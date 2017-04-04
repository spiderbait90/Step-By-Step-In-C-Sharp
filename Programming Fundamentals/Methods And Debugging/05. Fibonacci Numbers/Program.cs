using System;

namespace _05.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(Fib(n));

        }
        static long Fib(long n)
        {
            long num1 = 0;long num2 = 1;
            long num3 = 1;
            for (int i = 1; i <= n; i++)
            {
                num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
            }
            return num3;
        }
    }
}
