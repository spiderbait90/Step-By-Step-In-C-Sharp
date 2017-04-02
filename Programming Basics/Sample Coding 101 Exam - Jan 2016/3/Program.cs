using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());


            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
                if (Math.Max(first, second) - point > point - Math.Min(first, second))
                {
                    Console.WriteLine(point - Math.Min(first, second));
                }
                else if (Math.Max(first, second) - point < point - Math.Min(first, second))
                {
                    Console.WriteLine(Math.Max(first, second)-point);
                }
                else Console.WriteLine(Math.Max(first, second) - point);
            }
            else if (point > Math.Max(first, second))
            {
                Console.WriteLine("out");
                Console.WriteLine(point- Math.Max(first, second));
            }
            else if (point < Math.Min(first, second))
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(first, second)-point);
            }


        }
    }
}
