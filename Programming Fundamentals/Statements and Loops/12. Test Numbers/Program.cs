using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var combinations = 0;
            var sum = 0;
            while (n>0&&sum<maxSum)
            {
                for (int i = 1; i <= m; i++)
                {
                    sum += (3 * (n * i));
                    combinations++;
                    if (sum >= maxSum)
                        break;
                }
                n--;
            }
            if (sum>=maxSum)
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations");
                Console.WriteLine($"Sum: {sum}");
            }

        }
    }
}
