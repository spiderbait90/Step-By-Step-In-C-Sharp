using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());
            var apartament = 0.00;var studio = 0.00;
            if (month == "may" || month == "october")
            {
                apartament = nights * 65.00;
                studio = nights * 50.00;
            }
            else if (month == "june" || month == "september")
            {
                apartament = nights * 68.70;
                studio = nights * 75.20;
            }
            else if (month == "july" || month == "august")
            {
                apartament = nights * 77.00;
                studio = nights * 76.00;
            }
            if (nights > 7&&nights<=14&&(month=="may"||month=="october")) studio = studio - studio * 0.05;
            if (nights>14&& (month == "may" || month == "october")) studio = studio - studio * 0.30;
            if (nights>14 && (month == "june" || month == "september")) studio = studio - studio * 0.20;
            if (nights > 14) apartament = apartament - apartament * 0.10;
            Console.WriteLine($"Apartment: {apartament:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
