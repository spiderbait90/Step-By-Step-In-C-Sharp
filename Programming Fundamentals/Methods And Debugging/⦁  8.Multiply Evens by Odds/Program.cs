using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___8.Debugging_and_Program_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(EvenAndOdds(n));

        }
        static int EvenAndOdds(int n)
        {
            int SumOfEven = Even(n);
            int sumOfOdd = Odd(n);
            return SumOfEven * sumOfOdd;
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
