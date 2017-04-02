using System;

namespace ___8.Debugging_and_Program_Flow
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenAndOdds(n));

        }
        static int EvenAndOdds(int n)
        {
            int sumOfEven = Even(n);
            int sumOfOdd = Odd(n);
            return sumOfEven * sumOfOdd;
        }
        static int Odd(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                n /= 10;

            }
            return sum;
        }
        static int Even(int n)
        {
            int sum = 0;
            while (n !=0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                n /= 10;

            }
            return sum;
        }
    }
}
