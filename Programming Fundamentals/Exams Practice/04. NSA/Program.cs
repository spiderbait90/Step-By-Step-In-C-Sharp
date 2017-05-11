using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, Dictionary<string, long>>();

            while (input!="quit")
            {
                var split = input.Split(new[] { ' ', '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries);

                var countryName = split[0];
                var spyName = split[1];
                var daysInService = long.Parse(split[2]);

                if (!data.ContainsKey(countryName))
                    data[countryName] = new Dictionary<string, long>();

                if (data[countryName].ContainsKey(spyName))
                    data[countryName][spyName] = daysInService;

                else
                {
                    data[countryName].Add(spyName, daysInService);
                }

                input = Console.ReadLine();
            }
            foreach (var country in data.
                OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in country.Value
                    .OrderByDescending(x=>x.Value))                    
                {
                    Console.WriteLine($"**{spy.Key} : {spy.Value}");
                }

            }
        }
    }
}
