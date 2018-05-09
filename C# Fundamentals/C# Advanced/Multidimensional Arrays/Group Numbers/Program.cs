using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var matrix = new int[3][];

            matrix[0] = numbers.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            matrix[1] = numbers.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            matrix[2] = numbers.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
