using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Population_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string,
                Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split('|');
                if (input[0] == "report")
                    break;
                var city = input[0];
                var country = input[1];
                var population = long.Parse(input[2]);

                if (!data.ContainsKey(country))
                    data[country] = new Dictionary<string, long>();
                if (!data[country].ContainsKey(city))
                    data[country][city] = new long();

                data[country][city] += population;
            }

            foreach (var country in data
                .OrderByDescending(x=>x.Value.Values.Sum()))
            {
                Console.WriteLine($"{country.Key} (total population:" +
                    $" {country.Value.Values.Sum()})");

                foreach (var city in country.Value
                    .OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
