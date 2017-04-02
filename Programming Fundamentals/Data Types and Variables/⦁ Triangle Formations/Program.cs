using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _____Triangle_Formations
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("Triangle is valid.");
                if (a*a+b*b==c*c)                
                    Console.WriteLine("Triangle has a right angle between sides a and b");
                
                else if (b*b+c*c==a*a)
                    Console.WriteLine("Triangle has a right angle between sides b and c");
                
                else if (c*c+a*a==b*b)
                    Console.WriteLine("Triangle has a right angle between sides a and c");
                else
                    Console.WriteLine("Triangle has no right angles");

            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}
