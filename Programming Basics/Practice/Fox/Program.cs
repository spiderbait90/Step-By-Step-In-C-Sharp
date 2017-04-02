using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var wide = (2 * n) + 3; var stars = 1;
            var dash = wide - (stars * 2) - 2;

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*',stars));
                Console.Write("\\");
                Console.Write(new string('-', dash));
                Console.Write("/");
                Console.WriteLine(new string('*', stars));
                stars++;dash -= 2;
            }
            stars--;dash += 2;
            var sidestars = n / 2;
            for (int i = 1; i <= n/3; i++)
            {
                Console.Write("|");
                Console.Write(new string('*', sidestars));
                Console.Write("\\");
                Console.Write(new string('*', stars));
                Console.Write("/");
                Console.Write(new string('*', sidestars));
                Console.WriteLine("|");
                stars -= 2;sidestars++;
            }
            var midstars = wide - 4;
            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string('-', dash));
                Console.Write("\\");
                Console.Write(new string('*', midstars));
                Console.Write("/");
                Console.WriteLine(new string('-', dash));
                dash++;midstars -= 2;
            }

        }
    }
}
