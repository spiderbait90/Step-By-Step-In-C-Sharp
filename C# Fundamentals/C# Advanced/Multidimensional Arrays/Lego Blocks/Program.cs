using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstArr = FillArray(n);
            var secondArr = FillArray(n);
            var lenght = firstArr[0].Length + secondArr[0].Length;
            var check = true;

            for (int i = 1; i < firstArr.Length; i++)
            {
                if (lenght != firstArr[i].Length + secondArr[i].Length)
                {
                    check = false;
                }
            }

            if (check)
            {
                for (int r = 0; r < firstArr.Length; r++)
                {
                    var concated = firstArr[r].Concat(secondArr[r].Reverse()).ToArray();

                    firstArr[r] = concated;
                }

                foreach (var r in firstArr)
                {
                    Console.WriteLine("[" + string.Join(", ", r) + "]");
                }
            }
            else
            {
                var sum = 0;

                foreach (var r in firstArr)
                {
                    sum += r.Length;
                }
                foreach (var r in secondArr)
                {
                    sum += r.Length;
                }
                Console.WriteLine($"The total number of cells is: {sum}");
            }

        }

        private static long[][] FillArray(int n)
        {
            var arr = new long[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }
            return arr;
        }
    }
}
