using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var upperLeft = nums.Take(nums.Count / 4)
                .Reverse().ToList();

            nums.Reverse();

            var upperRight = nums.Take(nums.Count / 4)
                .ToList();

            upperLeft.AddRange(upperRight);
            var lower = nums.Skip(nums.Count / 4)
                .Take(nums.Count / 2)
                .Reverse().ToList();

            var sum = upperLeft.Select((x, index) => x + lower[index]).ToList();

            Console.WriteLine(string.Join(" ",sum));
        }
    }
}
