using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lambada_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, string>>();

            while (input!="lambada")
            {
                var splitInput = input.Split(new[] { ' ', '=', '>', '.' }
                , StringSplitOptions.RemoveEmptyEntries);                

                if (splitInput.Length==1)
                {

                    data = data
                        .ToDictionary(x => x.Key, x => x.Value
                           .ToDictionary(y => y.Key, y =>y.Key+"."+ y.Value));
                }
                else
                {
                    var key = splitInput[0];var subKey = splitInput[1];
                    var subKeyValue = splitInput[2];

                    if (!data.ContainsKey(key))
                    {
                        data[key] = new Dictionary<string, string>();
                        data[key].Add(subKey, subKeyValue);
                    }
                    else
                    {
                        if (data[key].ContainsKey(subKey))
                        {
                            data[key][subKey] = subKeyValue;
                        }
                        else
                        {
                            data[key].Add(subKey, subKeyValue);
                        }
                    }
                }
                input = Console.ReadLine();                
            }

            foreach (var item in data)
            {
                foreach (var subkey in item.Value)
                {
                    Console.WriteLine($"{item.Key}" +
                        $" => {subkey.Key}.{subkey.Value}");
                }
                
            }

        }
    }
}
