using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var proffesion = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            switch (proffesion)
            {
                case "Athlete":
                    Console.WriteLine($"The {proffesion} has to pay" +
                        $" {quantity*0.70:f2}.");break;
                case "Businessman":
                case "Businesswoman":
                    Console.WriteLine($"The {proffesion} has to pay" +
                        $" {quantity * 1.00:f2}."); break;
                case "SoftUni Student":
                    Console.WriteLine($"The {proffesion} has to pay" +
                        $" {quantity * 1.70:f2}."); break;
                default:
                    Console.WriteLine($"The {proffesion} has to pay" +
                        $" {quantity * 1.20:f2}."); break;
            }
        }
    }
}
