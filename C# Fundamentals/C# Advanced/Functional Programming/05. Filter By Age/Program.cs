using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var data = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                data.Add(input[0], int.Parse(input[1]));
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            if (condition == "younger")
            {
                data = data.Where(x => x.Value < age).ToDictionary(x => x.Key, a => a.Value);
            }
            else
            {
                data = data.Where(x => x.Value >= age).ToDictionary(k => k.Key, v => v.Value);
            }

            foreach (var pair in data)
            {
                switch (format)
                {
                    case "name":
                        Console.WriteLine(pair.Key);
                        break;
                    case "age":
                        Console.WriteLine(pair.Value);
                        break;
                    default:
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                        break;
                }
            }
        }
    }
}
