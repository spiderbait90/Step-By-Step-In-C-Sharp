using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            var matches = Regex.Matches(numbers, @"\+359(-| )2\1(\d{3})\1(\d{4})\b");
            var result = new List<string>();
            
            foreach (Match match in matches)
            {
                result.Add(match.Value);
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
