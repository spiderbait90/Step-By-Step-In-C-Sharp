using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix = new long[long.Parse(Console.ReadLine())][];

            for (long row = 0; row < matrix.Length; row++)
            {
                if (row == 0)
                    matrix[row] = new long[] { 1 };
                else if (row == 1)
                {
                    matrix[row] = new long[] { 1, 1 };
                }
                else
                {
                    matrix[row] = new long[row + 1];
                    matrix[row][0] = 1;
                    matrix[row][matrix[row].Length - 1] = 1;

                    for (long col = 1; col < row; col++)
                    {
                        matrix[row][col] = matrix[row - 1][col-1] + matrix[row - 1][col];
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
