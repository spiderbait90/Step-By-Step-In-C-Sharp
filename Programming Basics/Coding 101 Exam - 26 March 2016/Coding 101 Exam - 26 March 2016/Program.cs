using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_101_Exam___26_March_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var spent = 0.0;
            
            if (budget<=100.0)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer") spent = budget * 0.30;
                else if (season == "winter") spent =  budget * 0.70;

            }
            else if (budget <= 1000.0)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer") spent =  budget * 0.40;
                else if (season == "winter") spent = budget * 0.80;
            }
            else if (budget > 1000.0)
            {
                Console.WriteLine("Somewhere in Europe");
                spent = budget * 0.90;
                Console.WriteLine("Hotel - {0:f2}", spent);
                return;
            }
            if (season=="summer") Console.WriteLine("Camp - {0:f2}",spent);
            else if (season == "winter") Console.WriteLine("Hotel - {0:f2}", spent);


        }
    }
}
