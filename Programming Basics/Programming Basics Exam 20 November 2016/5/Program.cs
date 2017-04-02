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
            var space = 0;
            var stars = 2 * n;
            var dots = (3 * n - 2)/2;
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(new string('.', dots));
                if (i<=n)Console.Write("/");
                if (i > n + 1) Console.Write("|"+new string("\\",stars-2));
                if (i > 1 && i <= n) Console.Write(new string(' ', space));
                else if (i == n + 1) Console.Write(new string('*', stars));                
                if (i <= n)Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                space += space;
                if (i<n)dots--;
            }

        }
    }
}
