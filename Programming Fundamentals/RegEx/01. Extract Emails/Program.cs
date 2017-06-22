using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Practicee
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"[\w-.]+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {

                if (match.Value.StartsWith("-") ||
                    match.Value.StartsWith("_") ||
                    match.Value.StartsWith("."))
                {
                    /// do nothing;
                }
                else
                    Console.WriteLine(match.Value);
            }
        }
    }
}
