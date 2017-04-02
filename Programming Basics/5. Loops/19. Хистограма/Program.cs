using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Хистограма
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0; var p2 = 0; var p3 = 0; var p4 = 0; var p5 = 0; 
            for (int i = 0; i < n; i++)
            {
                var n1 = int.Parse(Console.ReadLine());
                if (n1 < 200) p1++;
                else if (n1 < 400) p2++;
                else if (n1 < 600) p3++;
                else if (n1 < 800) p4++;
                else p5++;
            }
            var p11 = p1 * 100.0 / n;
            var p22 = p2 * 100.0 / n;
            var p33 = p3 * 100.0 / n;
            var p44 = p4 * 100.0 / n;
            var p55 = p5 * 100.0 / n;
            Console.WriteLine($"{p11:f}%");
            Console.WriteLine($"{p22:f}%");
            Console.WriteLine($"{p33:f}%");
            Console.WriteLine($"{p44:f}%");
            Console.WriteLine($"{p55:f}%");
        }
    }
}
