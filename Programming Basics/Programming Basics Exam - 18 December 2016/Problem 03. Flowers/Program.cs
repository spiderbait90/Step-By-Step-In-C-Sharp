using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var flower1 = double.Parse(Console.ReadLine());
            var flower2 = double.Parse(Console.ReadLine());
            var flower3 = double.Parse(Console.ReadLine());
            var Season = Console.ReadLine();
            var PraznikOrNot = Console.ReadLine();
           
            if (Season=="Spring"||Season=="Summer")
            {                            
                   var total = flower1 * 2.00 + flower2 * 4.10 + flower3 * 2.50;
                   if (PraznikOrNot=="Y") total = total + (total * 0.15);               
                
                   if (flower1+flower2+flower3>20) total = total - (total * 0.20);
                   if (flower3 > 7&&Season=="Spring") total = total - (total * 0.05);
                   total = total + 2;
                Console.WriteLine($"{total:f2}");
            }
            else if (Season=="Autumn"||Season=="Winter")
            {
                 var total = flower1 * 3.75 + flower2 * 4.50 + flower3 * 4.15;
                if (PraznikOrNot == "Y") total = total + (total * 0.15);
                if (flower2 >= 10&&Season=="Winter") total = total - (total * 0.10);
                if (flower1 + flower2 + flower3 > 20) total = total - (total * 0.20);
                
                total = total + 2;
                Console.WriteLine($"{total:f2}");
            }
            

        }
    }
}
