using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var space = 0;
            var stars = 2 * n;
            var dots = (3 * n - 2) / 2;
            for (int i = 1; i <= (n+1+(2*n))+n/2; i++)
            {
                if (i == 2 * n + n + 2) stars-=2;
                if (i > 2 * n + n + 2) stars+=2;
                if (i > 2 * n + n + 2) dots--;
                Console.Write(new string('.', dots));
                if (i <= n|| i > 2 * n + n + 1) Console.Write("/");
                if (i > n + 1&&i<=2*n+n+1) Console.Write("|" + new string('\\', stars - 2)+"|");
                if (i > 1 && i <= n) Console.Write(new string(' ', space));
                else if (i == n + 1||i>=n+2+(2* n)) Console.Write(new string('*', stars));
                if (i <= n|| i > 2 * n + n + 1) Console.Write("\\");
                Console.WriteLine(new string('.', dots));
                space += 2;
                if (i < n) dots--;
                

            }
        }
    }
}
