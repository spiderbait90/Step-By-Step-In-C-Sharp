using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Fish_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(>*)<(\(+)('|-|x)>";

            var matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
                Console.WriteLine("No fish found.");
            else
            {
                var count = 1;
                foreach (Match fish in matches)
                {
                    var tail = fish.Groups[1].ToString();
                    var body = fish.Groups[2].ToString();
                    var status = fish.Groups[3].ToString();

                    Console.WriteLine($"Fish {count}: {fish}");

                    if (tail.Length > 5)
                        tail = "Long";
                    else if (tail.Length > 1)
                        tail = "Medium";
                    else if (tail.Length == 1)
                        tail = "Short";
                    else
                        tail = "None";

                    Console.Write($"  Tail type: {tail}");
                    if (tail != "None")
                        Console.WriteLine($" ({fish.Groups[1].ToString().Length * 2} cm)");
                    else
                        Console.WriteLine();

                    if (body.Length > 10)
                        body = "Long";
                    else if (body.Length > 5)
                        body = "Medium";
                    else
                        body = "Short";

                    Console.WriteLine($"  Body type: {body} " +
                        $"({fish.Groups[2].ToString().Length * 2} cm)");

                    if (status == "'")
                        status = "Awake";
                    else if (status == "-")
                        status = "Asleep";
                    else
                        status = "Dead";

                    Console.WriteLine($"  Status: {status}");
                    count++;
                }
            }
        }
    }
}
