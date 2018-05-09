using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var reasult = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse);

            Console.WriteLine(reasult.Count());
            Console.WriteLine(reasult.Sum());
        }
    }
}
