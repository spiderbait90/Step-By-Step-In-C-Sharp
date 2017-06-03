using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = ulong.Parse(Console.ReadLine());
            var lengtOfArr = FindLenthOfArr(n);
            var arr = new ulong[lengtOfArr];
            arr = FillWithAllPrimes(n, lengtOfArr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static ulong[] FillWithAllPrimes(ulong n, ulong lenthOfArr)
        {
            var arr = new ulong[lenthOfArr];
            var index = 0;
            for (ulong a = 2; a <= n; a++)
            {
                var check = true;
                for (ulong b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        check = false;
                }
                if (check == true)
                {
                    arr[index] = a;
                    index++;
                }
            }
            return arr;
        }

        static ulong FindLenthOfArr(ulong n)
        {
            ulong lengtOfArr = 0;
            for (ulong a = 2; a <= n; a++)
            {
                var check = true;
                for (ulong b = 2; b < a; b++)
                {
                    if (a % b == 0)
                        check = false;
                }
                if (check == true)
                {
                    lengtOfArr++;
                }
            }
            return lengtOfArr;
        }
    }
}
