using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUni_Coffee_Supplies
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var userCoffee = new Dictionary<string, string>();
            var coffeQuantity = new Dictionary<string, long>();
            var delimeters = Console.ReadLine().Split();

            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { $"{delimeters[0]}", $"{delimeters[1]}" },
                    StringSplitOptions.None)
                    .ToArray();
                if (input[0] == "end of info")
                    break;

                long quantity = 0;
                if (long.TryParse(input[1], out quantity))
                {
                    var coffe = input[0];
                    if (!coffeQuantity.ContainsKey(coffe))
                        coffeQuantity[coffe] = new long();
                    coffeQuantity[coffe] += quantity;
                }
                else
                {
                    var user = input[0];
                    var coffe = input[1];
                    userCoffee[user] = coffe;
                    if (!coffeQuantity.ContainsKey(coffe))
                        coffeQuantity[coffe] = new long();
                }
            }
            foreach (var coffe in coffeQuantity
                .Where(x => x.Value == 0))
            {
                Console.WriteLine($"Out of {coffe.Key}");
            }
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end of week")
                    break;
                var input = line.Split();
                var user = input[0];
                var quantity = long.Parse(input[1]);

                coffeQuantity[userCoffee[user]] -= quantity;
                if (coffeQuantity[userCoffee[user]] <= 0)
                    Console.WriteLine($"Out of {userCoffee[user]}");
            }
            coffeQuantity = coffeQuantity
                .OrderByDescending(x => x.Value)
                .Where(x => x.Value > 0)
                .ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine("Coffee Left:");
            foreach (var coffe in coffeQuantity)
            {
                Console.WriteLine($"{coffe.Key} {coffe.Value}");
            }
            Console.WriteLine("For:");
            foreach (var user in userCoffee
                .Where(x => coffeQuantity.ContainsKey(x.Value))
                .OrderBy(x => x.Value)
                .ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{user.Key} {user.Value}");
            }
        }
    }
}