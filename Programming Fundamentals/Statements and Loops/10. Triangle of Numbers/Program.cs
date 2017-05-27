using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int a = 0; a < i; a++)
                {
                    Console.Write(i);
                    if (a != i - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
