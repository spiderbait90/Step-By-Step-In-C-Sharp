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
            var n = int.Parse(Console.ReadLine());
            var wide = 2 * n - 1;
            var tall = 2 * (n - 2) + 1;
            var column = n - 1;
            for (int i = 1; i <= tall / 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write('\\');
                    Console.Write(' ');
                    Console.Write('/');
                    Console.WriteLine(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write('\\');
                    Console.Write(' ');
                    Console.Write('/');
                    Console.WriteLine(new string('-', n - 2));
                }
            }
            Console.Write(new string(' ', n - 1));
            Console.WriteLine('@');
            for (int i = 1; i <= tall / 2; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write('/');
                    Console.Write(' ');
                    Console.Write('\\');
                    Console.WriteLine(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write('/');
                    Console.Write(' ');
                    Console.Write('\\');
                    Console.WriteLine(new string('-', n - 2));
                }
            }

        }
    }
}
