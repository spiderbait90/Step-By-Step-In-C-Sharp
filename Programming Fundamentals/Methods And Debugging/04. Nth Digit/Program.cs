using System;

namespace _04.Nth_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number,n));
        }
        static int FindNthDigit(long number,int index)
        {
            var count = 0;long lastDigit;
            while(number>0)
            {
                count++;
                lastDigit = number % 10;
                number /= 10;                
                if (count==index)
                {
                    return (int)lastDigit;
                }                
            }
            return 0;
        }

    }
}
