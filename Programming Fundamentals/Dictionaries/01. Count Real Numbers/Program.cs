using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var result = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if(result.ContainsKey(number))
                {
                    result[number]++;
                }
                else
                {
                    result[number] = 1;
                }
            }
            foreach (var kv in result)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
    }
}
