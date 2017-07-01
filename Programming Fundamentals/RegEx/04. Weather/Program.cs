using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = new Regex(@"([A-Z]{2})(\d{1,2}.\d{1,10})([a-zA-Z]+)\|");
            var cityWeather = new Dictionary<string, string>();
            var cityTemp = new Dictionary<string, double>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                    break;
                var match = pattern.Match(input);
                if (!match.Success)
                    continue;
                var city = match.Groups[1].Value;
                var temp = double.Parse(match.Groups[2].Value);
                var weather = match.Groups[3].Value;
                cityWeather[city] = weather;
                cityTemp[city] = temp;
            }
            foreach (var item in cityTemp
                .OrderBy(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} => {item.Value:f2} " +
                    $"=> {cityWeather[item.Key]}");
            }
        }
    }
}
