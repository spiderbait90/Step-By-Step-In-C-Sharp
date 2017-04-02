using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = char.Parse(Console.ReadLine());
            var l2 = char.Parse(Console.ReadLine());
            var l3 = char.Parse(Console.ReadLine());
            var times = 0;
            for (var a = l1; a <=l2; a++)
            {
                for (var b = l1; b <= l2; b++)
                {
                    for (var c = l1; c <=l2; c++)
                    {
                        if (a != l3 && b != l3 & c != l3)
                        {
                            Console.Write($"{a}{b}{c} ");
                            times++;
                        }
                    }
                }
            }
            Console.WriteLine(times);
        }
    }
}
