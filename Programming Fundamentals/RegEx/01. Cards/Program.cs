using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(\d+|[JQKA])[SHDC]";

            var rege = Regex.Matches(input, pattern);
            var list = new List<string>();

            foreach (Match match in rege)
            {
                int power = 0;
                if (int.TryParse(match.Groups[1].ToString(), out power))
                {
                    if (power > 1 && power < 11)
                        list.Add(match.ToString());
                }
                else 
                    list.Add(match.ToString());
            }
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
