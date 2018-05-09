using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_sum_of_2x2_submatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            var matrix = new int[size[0]][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
            }
            var row = 0;
            var col = 0;
            var maxSum = 0;

            for (int i = 0; i < matrix.Length - 1; i++)
            {
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    var sum = matrix[i][j] + matrix[i][j + 1] + matrix[i + 1][j] + matrix[i + 1][j + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        row = i;
                        col = j;
                    }
                }
            }

            Console.WriteLine($"{matrix[row][col]} {matrix[row][col + 1]}");
            Console.WriteLine($"{matrix[row + 1][col]} {matrix[row + 1][col + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
