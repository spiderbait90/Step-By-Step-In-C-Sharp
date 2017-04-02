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
            Console.Write(new string('.', 2 * n - 1));
            Console.Write(new string('/', 1));
            Console.Write(new string('|', 1));
            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('.', 2 * n - 1));
            Console.Write(new string('.', 2 * n - 1));
            Console.Write(new string('\\', 1));
            Console.Write(new string('|', 1));
            Console.Write(new string('/', 1));
            Console.WriteLine(new string('.', 2 * n - 1));

            for (int i = 0; i < 2 * n; i++)
            {
                for (int a = 0; a < (2 * n - 1) - i; a++)
                {
                    Console.Write('.');
                }
                Console.Write('*');
                if (i == 0) Console.Write("**");
                else
                {
                    for (int b = 1; b <= 2; b++)
                    {
                        Console.Write(new string('-', i));
                        Console.Write('*');
                    }

                }

                for (int c = 0; c < (2 * n - 1) - i; c++)
                {
                    Console.Write('.');
                }
                Console.WriteLine();

            }

            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.Write('*');
                Console.Write('.');
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', 4 * n + 1));


        }
    }
}
