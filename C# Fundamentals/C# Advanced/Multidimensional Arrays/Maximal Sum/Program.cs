using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse)
                .ToArray();

            var matrix = new long[size[0]][];
            long maxSum = 0;
            var result = string.Empty;
            var roww = 0;
            var coll = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
            }

            for (long row = 0; row < matrix.Length - 2; row++)
            {
                for (long col = 0; col < matrix[row].Length - 2; col++)
                {
                    long sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                        matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                        matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        result =
                            $"{matrix[row][col]} {matrix[row][col + 1]} {matrix[row][col + 2]}{Environment.NewLine}" +
                            $"{matrix[row + 1][col]} {matrix[row + 1][col + 1]} {matrix[row + 1][col + 2]}{Environment.NewLine}" +
                            $"{matrix[row + 2][col]} {matrix[row + 2][col + 1]} {matrix[row + 2][col + 2]}";
                    }

                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(result);
        }
    }
}
