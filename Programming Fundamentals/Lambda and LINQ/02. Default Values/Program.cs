using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Default_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, string>();
            while (input != "end")
            {
                var splitInput = input.Split(new[] { ' ', '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

                var name = splitInput[0]; var value = splitInput[1];

                if (data.ContainsKey(name))
                    data[name] = value;
                else if (!data.ContainsKey(name))
                    data.Add(name, value);

                input = Console.ReadLine();
            }
            var word = Console.ReadLine();

            var nullValue = data
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => x.Value);

            data = data
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in nullValue)
            {
                data.Add(item.Key, word);
            }
            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} <-> {item.Value}");
            }
        }
    }
}
