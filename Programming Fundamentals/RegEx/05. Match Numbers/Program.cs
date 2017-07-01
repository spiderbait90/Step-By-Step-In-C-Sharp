using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches
                (input, @"(^|(?<=\s))([-]{0,1})(\d+)([.]{0,1})(\d*)($|(?=\s))");

            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
