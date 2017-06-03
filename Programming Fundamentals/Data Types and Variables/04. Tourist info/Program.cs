using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_info
{
    class Program
    {
        static void Main(string[] args)
        {
            var unit = Console.ReadLine();
            var n = double.Parse(Console.ReadLine());

            switch (unit)
            {
                case "miles": Console.WriteLine($"{n} {unit} = {1.6 * n:f2} kilometers"); break;
                case "inches": Console.WriteLine($"{n} {unit} = {2.54 * n:f2} centimeters"); break;
                case "feet": Console.WriteLine($"{n} {unit} = {30 * n:f2} centimeters"); break;
                case "yards": Console.WriteLine($"{n} {unit} = {0.91 * n:f2} meters"); break;
                case "gallons": Console.WriteLine($"{n} {unit} = {3.8 * n:f2} liters"); break;
                default:
                    break;
            }
        }
    }
}
