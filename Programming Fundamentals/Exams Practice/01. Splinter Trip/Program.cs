using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            /// 25L per mile
            /// 1.5 x strong winds
            /// 5% increase

            var distance = double.Parse(Console.ReadLine());
            var capacityTank = double.Parse(Console.ReadLine());
            var milesSpendHeavyWInds = double.Parse(Console.ReadLine());

            var milesNonHeavyWinds = distance - milesSpendHeavyWInds;
            var consumption = milesNonHeavyWinds * 25;
            var heavyConsumption = milesSpendHeavyWInds * (25 * 1.5);
            var fuelConsumption = consumption + heavyConsumption;
            var tolerance = fuelConsumption * 0.05;
            var totalFUelCons = tolerance + fuelConsumption;
            var remainingFuel = capacityTank - totalFUelCons;

            Console.WriteLine($"Fuel needed: {totalFUelCons:F2}L");

            if (remainingFuel>=0)
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            else
                Console.WriteLine($"We need {Math.Abs(remainingFuel):f2}L more fuel.");

        }
    }
}
