using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Housee
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var stars = 1;
            if (n % 2 == 0) stars++;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                var cherti = (n - stars) / 2;
                Console.Write(new string('-',cherti));
                Console.Write(new string('*', stars));
                Console.WriteLine(new string('-', cherti));
                stars += 2;
            }
            for (int i = 0; i < n / 2 ; i++)
            {
                Console.WriteLine("|"+new string('*',stars-4)+"|");
            }
        }
    }
}
