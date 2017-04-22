using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var bateries = Console.ReadLine().Split().Select(double.Parse)
                .ToArray();
            var usagePerHour = Console.ReadLine().Split().Select(double.Parse)
                .ToArray();
            var hours = int.Parse(Console.ReadLine());
            var result = new string[bateries.Length];
            var bateriesCapacity = new List<double>();
            var count = new int[bateries.Length];
            var baterie = 0;            
            for (int h = 0; h < hours; h++)
            {
                for (int i = 0; i < bateries.Length; i++)
                {
                    if (h == 0)
                        bateriesCapacity.Add(bateries[i]);
                    
                    bateries[i] -= usagePerHour[i];
                    if (bateries[i] <= 0 && count[i] == 0)
                    {
                        count[i] = 1;
                        baterie++;
                        result[i] = $"Battery {baterie}: dead (lasted {h + 1} hours)";

                    }
                    else if (bateries[i] > 0 && count[i] == 0)
                    {
                        baterie++;
                        result[i] = $"Battery {baterie}: {bateries[i]:f2} mAh ({(bateries[i]/bateriesCapacity[i])*100:f2})%";
                    }  
                    else
                        baterie++;
                }
                baterie = 0;
                
            }
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }
    }
}
