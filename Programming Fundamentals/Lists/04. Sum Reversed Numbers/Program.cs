using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var digits = Console.ReadLine()
                .Split()
                .Select(x => x.Reverse())
                .Select(x=>int.Parse(string.Concat(x)))                
                .Sum();

            Console.WriteLine(digits);
        }
    }
}
