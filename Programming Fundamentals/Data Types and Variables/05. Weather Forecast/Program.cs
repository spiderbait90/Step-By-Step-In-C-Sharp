using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            foreach (var item in n)
            {
                if (item=='.')
                {
                    Console.WriteLine("Rainy");
                    return;
                }
            }            
            if (long.Parse(n)>=sbyte.MinValue&& long.Parse(n) <= sbyte.MaxValue)
                Console.WriteLine("Sunny");
            else if (long.Parse(n) >= int.MinValue&& long.Parse(n) <= int.MaxValue)
                Console.WriteLine("Cloudy");
            else if (long.Parse(n) >= long.MinValue && long.Parse(n) <= long.MaxValue)
                Console.WriteLine("Windy");
            

        }
    }
}
