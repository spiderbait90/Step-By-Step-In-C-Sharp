using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Пътешествие
{
    class Program
    {
        static void Main(string[] args)
        {
            var Budget = double.Parse(Console.ReadLine());
            var Season = Console.ReadLine().ToLower();
            if (Budget<=100)
            {
                
                if (Season=="summer")
                {
                    var percent = Budget * 0.30;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {percent:f2}");
                }
                else if (Season=="winter")
                {
                    var percent = Budget * 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");/// it can be in the first IF-Else
                    Console.WriteLine($"Hotel - {percent:f2}");
                }
            }
            else if (Budget<=1000)
            {
                if (Season=="summer")
                {
                    var percent = Budget * 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                  
                    Console.WriteLine($"Camp - {percent:f2}");
                }
                else if (Season == "winter")
                {
                    var percent = Budget * 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {percent:f2}");
                }
            }
            else if (Budget>1000)
            {
                var percent = Budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {percent:f2}");
            }
        }
    }
}
