using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();

            var treesAndLenght = new Dictionary<string, List<double>>();
            var sumOfall = 0.0; var countOfAll = 0.0;
            while (input!="chop chop")
            {
                var splitInput = input.Split(new[] {' ','-','>'}
                ,StringSplitOptions.RemoveEmptyEntries);

                var type = splitInput[0];
                var height = int.Parse(splitInput[1]);
                if (!treesAndLenght.ContainsKey(type))
                    treesAndLenght[type] = new List<double>();
                treesAndLenght[type].Add(height);

                sumOfall += height; countOfAll++;

                input = Console.ReadLine();
            }
            var pickedTree = Console.ReadLine();
            var pickedHeight = double.Parse(Console.ReadLine());

            double pricePerMeter = Math.Round((sumOfall / countOfAll),2);
            var usedLogs = 0.0;
            var unUsedLOgs = 0.0;
            foreach (var tree in treesAndLenght)
            {
                foreach (var value in tree.Value)
                {
                    if (value>=pickedHeight&&tree.Key==pickedTree)
                    {
                        usedLogs += value;
                    }
                    else
                    {
                        unUsedLOgs += value;
                    }
                }
            }
            var usedLOgsPrice = Math.Round((usedLogs * pricePerMeter),2);
            var unUsedLogsPrice = Math.Round((unUsedLOgs * pricePerMeter * 0.25),2);
            var result = usedLOgsPrice + unUsedLogsPrice;

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLOgsPrice:f2}");
            Console.WriteLine($"Unused logs price: ${unUsedLogsPrice:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${result:f2}");
            
        }
    }
}
