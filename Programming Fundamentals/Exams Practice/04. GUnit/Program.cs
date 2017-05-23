using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.GUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+) \| ([A-Z][A-Za-z0-9]+)$");
            var data = new Dictionary<string, Dictionary<string, List<string>>>();
            
            while (input!= "It's testing time!")
            {
                var match = regex.Match(input);

                if (regex.IsMatch(input))
                {
                    var clas = match.Groups[1].ToString();
                    var method = match.Groups[2].ToString();
                    var unit = match.Groups[3].ToString();

                    if (!data.ContainsKey(clas))
                        data[clas] = new Dictionary<string, List<string>>();

                    if (!data[clas].ContainsKey(method))
                        data[clas][method] = new List<string>();

                    if (!data[clas][method].Contains(unit))
                        data[clas][method].Add(unit);
                }               
                
                input = Console.ReadLine();
            }            

            foreach (var clas in data
                .OrderByDescending(x=>x.Value.Values.Sum(y=>y.Count))             
                .ThenBy(x=>x.Value.Count)
                .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{clas.Key}:");
                foreach (var method in clas.Value
                    .OrderByDescending(x=>x.Value.Count)
                    .ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"##{method.Key}");
                    foreach (var unit in method.Value
                        .OrderBy(x=>x.Length)
                        .ThenBy(x=>x))
                    {
                        Console.WriteLine($"####{unit}");
                    }
                }
            }
        }
    }
}
