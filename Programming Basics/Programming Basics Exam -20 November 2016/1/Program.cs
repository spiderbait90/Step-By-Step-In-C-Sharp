using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumria = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palamud = double.Parse(Console.ReadLine());
            var safrid = double.Parse(Console.ReadLine());
            var midi = double.Parse(Console.ReadLine());
            var palamud2 = (skumria + skumria * 0.60) * palamud;
            var safrid2 = (caca + caca * 0.80) * safrid;
            var midi2 = midi * 7.50;
            var total = palamud2 + safrid2 + midi2;
            Console.WriteLine($"{total:f2}");
            
        }
    }
}
