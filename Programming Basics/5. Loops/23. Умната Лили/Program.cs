using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Умната_Лили
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var peralnq = double.Parse(Console.ReadLine());
            var price1toy = int.Parse(Console.ReadLine());
            var oddtoys = 0;var evenmoney = 0.0;

            for (int i = 1; i <= age; i++)
            {
               if (i%2==0)
                {
                    evenmoney = evenmoney + (5*i)-1;
                    
                }
               else
                {
                    oddtoys++;
                }
            }
            var moneytoys = oddtoys * price1toy;
            var total = evenmoney + moneytoys;
            if (total>=peralnq)
            {
                Console.WriteLine($"Yes! {total-peralnq:f2}");
            }
            else if (total<peralnq)
            {
                Console.WriteLine($"No! {peralnq-total:f2}");
            }
        }
    }
}
