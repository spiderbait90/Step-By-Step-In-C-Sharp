using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var kind = Console.ReadLine();
            double price = 0;
            var place = string.Empty;

            if (groupSize <= 50)
            {
                place = "Small Hall";
                price += 2500;
            }
            else if (groupSize <= 100)
            {
                place = "Terrace";
                price += 5000;
            }
            else if (groupSize <= 120)
            {
                place = "Great Hall";
                price += 7500;
            }
            if (kind == "Normal")
            {
                price += 500;
                price = price - (price * 0.05);
            }
            else if (kind == "Gold")
            {
                price += 750;
                price = price - (price * 0.10);
            }
            else if (kind == "Platinum")
            {
                price += 1000;
                price = price - (price * 0.15);
            }
            if (groupSize > 120)
                Console.WriteLine("We do not have an appropriate hall.");
            else
            {
                Console.WriteLine($"We can offer you the {place}");
                Console.WriteLine($"The price per person is {price / groupSize:f2}$");
            }
        }
    }
}
