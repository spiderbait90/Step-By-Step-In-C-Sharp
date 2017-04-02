using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var pricePeralna = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());
            var Oddtoys=0;var Evenmoney=0.0;
            

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0) Oddtoys++;
                else if (i % 2 == 0)
                {
                    Evenmoney =Evenmoney+(i*5.00);
                    Evenmoney -= 1.00;
                }
            }
            var Toys = Oddtoys * priceToy;
            var total = Evenmoney + Toys;
            if (total >= pricePeralna) Console.WriteLine($"Yes! {total-pricePeralna:f2}");
            else if (total < pricePeralna) Console.WriteLine($"No! {pricePeralna-total:f2}");  

        }
    }
}
