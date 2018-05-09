using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderBy(x => x)
                .ToArray();

            var first = numbers.Where(x => x % 2 == 0);
            var second = numbers.Where(x => x % 2 != 0);

            Console.WriteLine(string.Join(" ", first) + " " + string.Join(" ", second));
        }
    }
}
