using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Dict_Ref_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, List<int>>();
            while (input!="end")
            {
                var nameAndValues =
                    input.Split(new[] { '-', '>', ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);
                var name = nameAndValues[0];
                if (!data.ContainsKey(name))
                {
                    data[name] = new List<int>();
                }
                var parsed = 0;
                if(int.TryParse(nameAndValues[1],out parsed))
                {
                    for (int i = 1; i < nameAndValues.Length; i++)
                    {
                        data[name].Add(int.Parse(nameAndValues[i]));
                    }
                }
                else
                {
                    if (!data.ContainsKey(nameAndValues[1]))
                    {
                        data.Remove(name);
                    }
                    else
                    {
                        foreach (var value in data[nameAndValues[1]])
                        {
                            data[name].Add(value);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var name in data)
            {
                Console.WriteLine($"{name.Key} === " +
                    $"{string.Join(", ",name.Value)}");
            }
        }
    }
}
