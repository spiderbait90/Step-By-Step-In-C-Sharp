using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var capacity = 255;
            var total = 0;
            for (int i = 0; i < n; i++)
            {
                var ltr = int.Parse(Console.ReadLine());
                if (ltr+total > capacity)
                    Console.WriteLine("Insufficient capacity!");
                else
                    total += ltr;
            }
            Console.WriteLine(total);
        }
    }
}
