using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = long.Parse(Console.ReadLine());
            var n2 = long.Parse(Console.ReadLine());

            var min = Math.Min(n1, n2);
            var max = Math.Max(n1, n2);

            var result = (min * 4) + (max * 10);

            Console.WriteLine(result);
        }
    }
}
