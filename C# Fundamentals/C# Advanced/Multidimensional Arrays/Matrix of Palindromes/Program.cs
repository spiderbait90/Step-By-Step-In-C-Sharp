using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var row = input[0];
            var col = input[1];
            var alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var matrix = new string[row][];
            var count = 0;

            for (int r = 0; r < matrix.Length; r++)
            {
                matrix[r] = new string[col];

                for (int c = 0; c < matrix[r].Length; c++)
                {
                    matrix[r][c] = $"{alphabet[r]}{alphabet[c+count]}{alphabet[r]}";
                }
                count++;
            }

            foreach (var r in matrix)
            {
                Console.WriteLine(string.Join(" ",r));
            }
        }
    }
}
