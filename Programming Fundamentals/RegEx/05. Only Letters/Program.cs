using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var matches = Regex.Matches(text, @"(\d+)([a-zA-Z])");

            foreach (Match match in matches)
            {
                text = Regex.Replace
                    (text, $@"{match.Groups[1].Value}", $@"{match.Groups[2].Value}");
            }
            Console.WriteLine(text);
        }
    }
}
