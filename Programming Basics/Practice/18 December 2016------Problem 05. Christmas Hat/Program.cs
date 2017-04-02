using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_December_2016______Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 4 * n + 1; var high = 2 * n + 5;
            var dots = (wide - 3)/2;var dash = 0;

            Console.Write(new string ('.',dots));
            Console.Write("/|\\");
            Console.WriteLine(new string('.', dots));
            Console.Write(new string('.', dots));
            Console.Write("\\|/");
            Console.WriteLine(new string('.', dots));
            for (int i = 1; i <= 2*n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("*");
                Console.Write(new string('-', dash));
                Console.Write("*");
                Console.Write(new string('-', dash));
                Console.Write("*");
                Console.WriteLine(new string('.', dots));
                dots--;dash++;
            }
            Console.WriteLine(new string('*', wide));
            for (int i = 1; i <= wide/2; i++)
            {
                Console.Write('*');
                Console.Write('.');
            }
            Console.WriteLine('*');
            Console.WriteLine(new string('*', wide));
        }
    }
}
