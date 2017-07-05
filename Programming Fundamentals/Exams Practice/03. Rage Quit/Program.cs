using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, @"([^\d]+)(\d+)");
            var str = new StringBuilder();
            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].Value.ToUpper();
                var times = int.Parse(match.Groups[2].Value);
                str.Append(string.Join("", Enumerable.Repeat(symbols, times)));
            }
            Console.WriteLine($"Unique symbols used: {str.ToString().Distinct().Count()}");
            Console.WriteLine(str.ToString());
        }
    }
}
