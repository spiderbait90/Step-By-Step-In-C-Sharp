using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(input,
                @"\b(\d{2})(-|\/|\.)([A-Z][a-z]{2})\2(\d{4})\b");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups[1]}," +
                    $" Month: {match.Groups[3]}, Year: {match.Groups[4]}");
            }
        }
    }
}
