using System;

namespace _06.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }
        static bool IsPrime(long n)
        {
            if (n < 2)
                return false;
            else
            {
                bool check = true;                
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {                    
                    if (n%i == 0)
                        check = false;
                }
                return check;
            }
        }
    }
}
