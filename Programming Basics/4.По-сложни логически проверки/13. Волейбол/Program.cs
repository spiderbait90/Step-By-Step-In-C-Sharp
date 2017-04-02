using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Волейбол
{
    class Program
    {
        static void Main(string[] args)
        {
            var leapOrNot = Console.ReadLine().ToLower();
            var praznik = double.Parse(Console.ReadLine());
            var weekends = double.Parse(Console.ReadLine());
            if (leapOrNot == "leap")
            {

                var total = ((48-weekends) * 3.0 / 4.0) + weekends +(praznik * 2.0 / 3.0);
                var totalperc = (total *15/100);
                Console.WriteLine(Math.Truncate(totalperc + total));
            }
            else if (leapOrNot == "normal")
            {
                Console.WriteLine(Math.Truncate(((48-weekends) * 3.0 / 4) + weekends + (praznik * 2.0 / 3)));
            }


        }
    }
}
