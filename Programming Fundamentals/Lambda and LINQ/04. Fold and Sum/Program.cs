using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var left = numbers
                .Take((numbers.Count / 2) / 2)
                .Reverse().ToList();

            numbers.Reverse();

            var right = numbers
                .Take((numbers.Count / 2) / 2)
                .ToList();

            numbers.Reverse();

            var upperRow = left.Concat(right).ToList();

            var lowerRow = numbers
                .Skip((numbers.Count / 2) / 2)
                .Take(numbers.Count / 2)
                .ToList();

            var sum = upperRow
                .Select((n, index) => n + lowerRow[index])
                .ToList();
            var sum2 = new List<int>();            
            
            Console.WriteLine(string.Join(" ", sum));
            
        }
    }
}
