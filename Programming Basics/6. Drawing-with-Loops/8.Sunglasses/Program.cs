using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            for (int i = 0; i < n - 2; i++)
            {
                if (i== (n - 1) / 2 - 1)
                {
                    Console.Write("*");
                    Console.Write(new string ('/',2*n-2));
                    Console.Write("*");
                    Console.Write(new string('|',n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                    
            }
            
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));

        }
    }
}
