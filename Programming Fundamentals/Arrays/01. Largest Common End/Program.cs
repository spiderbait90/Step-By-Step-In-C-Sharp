using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split();
            var arr2 = Console.ReadLine().Split();
            var count = 0;
            int[] min = new int[Math.Min(arr1.Length, arr2.Length)];
            int[] max = new int[Math.Max(arr1.Length, arr2.Length)];
            for (int i = 0; i < min.Length; i++)
            {
                if (arr1[i] == arr2[i])
                    count++;
            }
            var count2 = 0;
            for (int i = min.Length - 1; i >= 0; i--)
            {
                if (arr1.Length == max.Length)
                {
                    if (arr1[i + (arr1.Length - arr2.Length)] == arr2[i])
                        count2++;
                }
                else
                {
                    if (arr2[i + (arr2.Length - arr1.Length)] == arr1[i])
                        count2++;
                }
            }
            Console.WriteLine(Math.Max(count, count2));
        }
    }
}
