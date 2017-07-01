using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var matches = Regex.Matches(input, @"\b[0x]*[0-9A-F]+\b");

            foreach (Match match in matches)
            {
                Console.Write(match.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
