using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var primes = ListPrimes(startNum, endNum);
            Console.WriteLine(string.Join(", ",primes));

        }

        static List<int> ListPrimes(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i) == true)
                    primes.Add(i);

            }
            return primes;

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
                    if (n % i == 0)
                        check = false;
                }
                return check;
            }
        }
    }
}
