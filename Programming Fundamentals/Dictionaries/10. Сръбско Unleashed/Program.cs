using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, Dictionary<string, long>>();
            var regex = new Regex(@"^([A-Za-z ]+) @([A-Za-z ]+) (\d+) (\d+)");
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                    break;                
                
                if (regex.IsMatch(input))
                {
                    var match = regex.Match(input);
                    var name = match.Groups[1].ToString();
                    var place = match.Groups[2].ToString();
                    var ticketCount = int.Parse(match.Groups[3].ToString());
                    var ticketPrice = int.Parse(match.Groups[4].ToString());

                    if (!data.ContainsKey(place))
                        data[place] = new Dictionary<string, long>();
                    if (!data[place].ContainsKey(name))
                        data[place][name] = new long();

                    data[place][name] += (ticketPrice * ticketCount);
                }
            }

            foreach (var place in data)
            {
                Console.WriteLine($"{place.Key}");
                foreach (var item in place.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
