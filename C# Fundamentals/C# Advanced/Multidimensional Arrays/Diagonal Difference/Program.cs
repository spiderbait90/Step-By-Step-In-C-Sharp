using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = long.Parse(Console.ReadLine());
            var matrix = new long[size][];
            long left = 0;
            long right = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new long[size];
                matrix[i] = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }
            var row = 0;
            var col = 0;

            while (matrix.Length > row)
            {
                left += matrix[row][col];
                row++;
                col++;
            }
            row = 0;
            col--;
            while (matrix.Length > row)
            {
                right += matrix[row][col];
                row++;
                col--;
            }

            Console.WriteLine(Math.Abs(left-right));

        }
    }
}
