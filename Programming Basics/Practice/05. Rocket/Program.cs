using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 3 * n;var dots = (wide - 2) / 2;
            var space = 0;var stars = (2 * n) - 2;

            for (int top = 1; top <= n; top++)
            {
                Console.Write(new string('.',dots));
                Console.Write('/');
                if (top>1) Console.Write(new string(' ', space));
                Console.Write('\\');
                Console.WriteLine(new string('.', dots));
                space += 2;dots--;
            }

            dots++;
            Console.Write(new string('.', dots));
            Console.Write(new string('*', 2*n));
            Console.WriteLine(new string('.', dots));

            for (int mid = 1; mid <= 2*n; mid++)
            {
                Console.Write(new string('.', dots));
                Console.Write("|");
                Console.Write(new string('\\', (2*n)-2));
                Console.Write("|");
                Console.WriteLine(new string('.', dots));
            }
            for (int bot = 1; bot <= n/2; bot++)
            {
                Console.Write(new string('.', dots));
                Console.Write("/");
                Console.Write(new string('*', stars));
                Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                stars += 2;dots--;

            }

        }
    }
}
