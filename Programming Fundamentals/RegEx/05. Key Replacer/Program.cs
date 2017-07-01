using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = Regex.Match
                (Console.ReadLine(),
                @"^([A-Za-z]+).+(\||<|\\)([a-zA-Z]+)$");

            var words = Regex.Matches(Console.ReadLine(),
                $@"{keys.Groups[1].Value}(.*?){keys.Groups[3].Value}");

            var check = false;
            foreach (Match word in words)
            {
                if (word.Groups[1].Value != "")
                {
                    Console.Write(word.Groups[1].Value);
                    check = true;
                }
            }
            if (!check)
                Console.WriteLine("Empty result");
        }
    }
}
