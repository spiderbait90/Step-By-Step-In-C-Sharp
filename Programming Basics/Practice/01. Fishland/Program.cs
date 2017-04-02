using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skum = double.Parse(Console.ReadLine());
            var caca = double.Parse(Console.ReadLine());
            var palam = double.Parse(Console.ReadLine());
            var safrid = double.Parse(Console.ReadLine());
            var midi = int.Parse(Console.ReadLine());

            double pricepalam = skum + (skum * 0.60);
            pricepalam *= palam;
            double pricesafrid = caca + (caca * 0.80);
            pricesafrid *= safrid;
            double pricemidi = midi * 7.50;
            var total = pricesafrid + pricepalam + pricemidi;
            Console.WriteLine($"{total:f2}");
        }
    }
}
