using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            decimal profit = 0;
            decimal lost = 0;
            for (int i = 0; i < n; i++)
            {
                var adultCount = long.Parse(Console.ReadLine());
                var adultPrice = decimal.Parse(Console.ReadLine());
                var youthCount = long.Parse(Console.ReadLine());
                var youthPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerH = decimal.Parse(Console.ReadLine());
                var fuelConsumpPerH = decimal.Parse(Console.ReadLine());
                var flightDuration = int.Parse(Console.ReadLine());

                var income = (adultCount * adultPrice) + (youthCount * youthPrice);
                var expenses = flightDuration * fuelConsumpPerH * fuelPricePerH;

                var result = income - expenses;
                if (income>=expenses)
                {
                    Console.WriteLine($"You are ahead with {result:f3}$.");
                    profit += result;
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {result:f3}$.");
                    lost += Math.Abs(result);
                }

            }
            Console.WriteLine($"Overall profit -> {profit-lost:f3}$.");
            Console.WriteLine($"Average profit -> {(profit - lost)/n:f3}$.");
        }
    }
}
