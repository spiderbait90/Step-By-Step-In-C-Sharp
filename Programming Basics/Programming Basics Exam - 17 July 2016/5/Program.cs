using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 5 * n;var hight = 3 * n + 2;
            var dots = n; var stars = wide - 2 * n;
            var middots = wide - 2 * n;

            Console.Write(new string('.',dots));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('.', dots));
            dots--;
            for (int top = 1; top <= n-1; top++)
            {
                Console.Write(new string('.',dots));
                Console.Write('*');
                Console.Write(new string('.', middots));
                Console.Write('*');
                Console.WriteLine(new string('.', dots));
                dots--;middots+=2;
            }
            Console.WriteLine(new string('*',wide));
            dots++;middots -= 2;
            for (int bot = 1; bot <= 2*n; bot++)
            {
                Console.Write(new string('.', dots));
                Console.Write('*');
                Console.Write(new string('.', middots));
                Console.Write('*');
                Console.WriteLine(new string('.', dots));
                dots++; middots -= 2;
            }
            Console.Write(new string('.', dots));
            Console.Write('*');
            Console.Write(new string('*', middots));
            Console.Write('*');
            Console.WriteLine(new string('.', dots));

        }
    }
}
