using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] {'=',' '},StringSplitOptions.RemoveEmptyEntries);
            var dictionary = new Dictionary<string, int>();
            while (input.Length > 1)
            {
                var parsed = 0;
                if (dictionary.ContainsKey(input[1]))
                {
                    dictionary[input[0]] = dictionary[input[1]];
                }                
                else if (int.TryParse(input[1],out parsed))
                {
                    dictionary[input[0]] = parsed;
                }                
                input = Console.ReadLine().Split(new[] { '=', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var kv in dictionary)
            {
                Console.WriteLine($"{kv.Key} === {kv.Value}");
            }
        }
    }
}
