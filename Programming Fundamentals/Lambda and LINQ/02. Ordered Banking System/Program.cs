using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ordered_Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var data = new Dictionary<string, Dictionary<string, decimal>>();

            while (input!="end")
            {
                var splitInput = input.Split(new[] { ' ', '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries);

                var bank = splitInput[0];var name = splitInput[1];
                var money = decimal.Parse(splitInput[2]);

                if(!data.ContainsKey(bank))
                {
                    data[bank] = new Dictionary<string, decimal>();
                    data[bank].Add(name, money);
                }
                else
                {
                    if(data[bank].ContainsKey(name))
                    {
                        data[bank][name] += money;
                    }
                    else
                    {
                        data[bank].Add(name, money);
                    }
                }
                input = Console.ReadLine();
            }

            var orderedData = data.OrderByDescending(bank => bank.Value.Sum(acc => acc.Value))
                .ThenByDescending(bank => bank.Value.Max(acc => acc.Value))                
                .ToDictionary(x => x.Key, x => x.Value.OrderByDescending(acc =>acc.Value));

            foreach (var bank in orderedData)
            {
                foreach (var acc in bank.Value)
                {
                    Console.WriteLine($"{acc.Key} -> {acc.Value} ({bank.Key})");
                }
            }
        }
    }
}
