using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new []{',',' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            var rows = input[0];
            var arr = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                arr[i] = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].Sum();
            }

            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[0].Length);
            Console.WriteLine(sum);
        }
    }
}
