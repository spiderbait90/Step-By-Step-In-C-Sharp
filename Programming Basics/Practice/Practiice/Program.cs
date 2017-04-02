using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiice
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = n;var stars = 2*n;
            var wide = n * 5;
            Console.Write(new string('*',stars));
            Console.Write(new string(' ', space));
            Console.WriteLine(new string('*', stars));
            
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/',stars-2));
                Console.Write("*");              
                if (i== (n - 1) / 2 ) Console.Write(new string('|', space));
                else Console.Write(new string(' ', space));
                Console.Write("*");
                Console.Write(new string('/', stars - 2));
                Console.WriteLine("*");

            }
            Console.Write(new string('*', stars));
            Console.Write(new string(' ', space));
            Console.WriteLine(new string('*', stars));

        }
    }
}
