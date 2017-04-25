using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Flatten_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, string>>();
            var concated = new List<string>();
            while (input != "end")
            {
                var splitInput = input.Split(' ');
                var type = splitInput[0]; var model = splitInput[1];
                if (type == "flatten")
                {
                    data[model] = data[model].ToDictionary(x => x.Key + x.Value, x => "flatten");
                }
                else
                {                    
                    var subModel = splitInput[2];
                    if (!data.ContainsKey(type))
                    {
                        data[type] = new Dictionary<string, string>();
                    }
                    if (data[type].ContainsKey(model))
                    {
                        data[type][model] = subModel;
                    }
                    else
                    {
                        data[type].Add(model, subModel);
                    }
                }
                input = Console.ReadLine();
            }
            var count = 1;
            data = data.OrderByDescending(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

            foreach (var type in data)
            {
                Console.WriteLine($"{type.Key}");

                var innerKeys = type.Value.Where(x => x.Value != "flatten")
                    .OrderBy(x => x.Key.Length).ToDictionary(x => x.Key, x => x.Value);

                var flatten = type.Value.Where(x => x.Value == "flatten")
                    .ToDictionary(x => x.Key, x => x.Value);

                foreach (var kv in innerKeys)
                {
                    Console.WriteLine($"{count}. {kv.Key} - {kv.Value}");
                    count++;
                }

                foreach (var kv in flatten)
                {
                    Console.WriteLine($"{count}. {kv.Key}");
                    count++;
                }

                count = 1;
            }

        }
    }
}
