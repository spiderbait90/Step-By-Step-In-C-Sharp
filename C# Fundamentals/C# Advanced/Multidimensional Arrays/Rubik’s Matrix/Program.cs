using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rubik_s_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

            var matrix = FillMatrix();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var dir = input[1];
                var rowCow = int.Parse(input[0]);
                var times = int.Parse(input[2]);

                if (dir == "up")
                {
                    for (int t = 0; t < times % matrix[0].Length; t++)
                    {
                        var temp = matrix[0][rowCow];
                        for (int j = 0; j < matrix.Length - 1; j++)
                        {
                            matrix[j][rowCow] = matrix[j + 1][rowCow];
                        }
                        matrix[matrix.Length - 1][rowCow] = temp;
                    }

                }
                else if (dir == "down")
                {
                    for (int t = 0; t < times % matrix[0].Length; t++)
                    {
                        var temp = matrix[matrix.Length - 1][rowCow];
                        for (int j = matrix.Length - 1; j > 0; j--)
                        {
                            matrix[j][rowCow] = matrix[j - 1][rowCow];
                        }
                        matrix[0][rowCow] = temp;
                    }
                }
                else if (dir == "left")
                {
                    for (int t = 0; t < times % matrix.Length; t++)
                    {
                        var temp = matrix[rowCow][0];
                        for (int j = 0; j < matrix.Length - 1; j++)
                        {
                            matrix[rowCow][j] = matrix[rowCow][j + 1];
                        }
                        matrix[rowCow][matrix[rowCow].Length - 1] = temp;
                    }
                }
                else if (dir == "right")
                {
                    for (int t = 0; t < times % matrix.Length; t++)
                    {
                        var temp = matrix[rowCow][matrix[rowCow].Length - 1];
                        for (int j = matrix.Length - 1; j > 0; j--)
                        {
                            matrix[rowCow][j] = matrix[rowCow][j - 1];
                        }
                        matrix[rowCow][0] = temp;
                    }
                }
            }
            var count = 1;

            for (int r = 0; r < matrix.Length; r++)
            {
                for (int c = 0; c < matrix[r].Length; c++)
                {
                    if (count == matrix[r][c])
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {

                        for (int a = 0; a < matrix.Length; a++)
                        {
                            for (int b = 0; b < matrix[a].Length; b++)
                            {
                                if (matrix[a][b] == count)
                                {
                                    var temp = matrix[r][c];
                                    matrix[r][c] = count;
                                    matrix[a][b] = temp;

                                    Console.WriteLine($"Swap ({r}, {c}) with ({a}, {b})");
                                }
                            }

                        }
                    }
                    count++;
                }
            }

        }

        private static int[][] FillMatrix()
        {
            var size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var r = size[0];
            var c = size[1];
            var count = 1;
            var matrix = new int[r][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[c];
                for (int col = 0; col < matrix[row].Length; col++)
                {

                    matrix[row][col] = count;
                    count++;
                }
            }

            return matrix;
        }
    }
}
