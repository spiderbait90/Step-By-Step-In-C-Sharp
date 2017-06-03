using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var k = long.Parse(Console.ReadLine());
            var arr = new long[n];
            arr[0] = 1;

            for (long i = 1; i < n; i++)
            {
                for (long a = 0; a < i; a++)
                {
                    if (a < i - k)
                        continue;
                    arr[i] += arr[a];
                }
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
