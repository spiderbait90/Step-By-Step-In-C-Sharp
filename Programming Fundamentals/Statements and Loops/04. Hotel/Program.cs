using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var studio = 0.0; var doouble = 0.0; var suite = 0.0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                doouble = 65 * nights;
                suite = 75 * nights;

                if (nights > 7)
                {
                    studio = (50 - (50 * 0.05)) * nights;
                    if (month == "October")
                        studio = (50 - (50 * 0.05)) * (nights-1);
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 60 * nights;
                doouble = 72 * nights;
                suite = 82 * nights;
                if (nights > 14)
                    doouble = (72 - (72 * 0.10)) * nights;

                if (nights > 7 && month == "September")
                    studio = 60 * (nights - 1);
            }
            else if (month == "July" || month == "August"
                    || month == "December")
            {
                studio = 68 * nights;
                doouble = 77 * nights;
                suite = 89 * nights;

                if (nights > 14)
                    suite = (89 - (89 * 0.15)) * nights;
            }

            Console.WriteLine($"Studio: {studio:f2} lv.");
            Console.WriteLine($"Double: {doouble:f2} lv.");
            Console.WriteLine($"Suite: {suite:f2} lv.");
        }
    }
}
