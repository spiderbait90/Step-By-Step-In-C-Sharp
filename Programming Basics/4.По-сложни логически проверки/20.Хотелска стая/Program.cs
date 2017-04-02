using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Хотелска_стая
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = Console.ReadLine().ToLower();
            var days = double.Parse(Console.ReadLine());
            if (months=="may"||months=="october")
            {
                if (days<8)
                {
                    Console.WriteLine($"Apartment: {days * 65:f2} lv.");
                    Console.WriteLine($"Studio: {days * 50:f2} lv.");
                }
                else if (days>7&&days<15)
                {
                    var studio = days * 50 - ((days * 50) * 5 / 100);
                    Console.WriteLine($"Apartment: {days * 65:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                }
                else if (days>14)
                {
                    var studio = days * 50 - ((days * 50) * 30 / 100);
                    var apartament = days * 65 - ((days * 65) * 10 / 100);
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                }

            }
            else if (months == "june" || months == "september")
            {
                if (days < 15)
                {
                    Console.WriteLine($"Apartment: {days * 68.70:f2} lv.");
                    Console.WriteLine($"Studio: {days * 75.20:f2} lv.");
                }
                else if (days>14)
                {
                    var studio = days * 75.20 - ((days * 75.20) * 20 / 100);
                    var apartament = days * 68.70 - ((days * 68.70) * 10 / 100);
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                }
            }
            else if (months == "july" || months == "august")
            {
                if (days < 15)
                {
                    Console.WriteLine($"Apartment: {days * 77:f2} lv.");
                    Console.WriteLine($"Studio: {days * 76:f2} lv.");
                }
                else
                {
                    var apartament = days * 77 - ((days * 77) * 10 / 100);
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {days * 76:f2} lv.");
                }
            }
        }
    }
}
