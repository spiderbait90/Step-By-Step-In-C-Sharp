using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new[] { ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            var numbersCheck = @"[\+\-]*[0-9]+\.*[0-9]*";
            var charCheck = @"[^\d\+\-\*\/\.]";
            var symbolsCheck = @"[\*\/]";

            var result = new List<string>();
            foreach (var demon in demons)
            {
                var numbers = Regex.Matches(demon, numbersCheck);
                var chars = Regex.Matches(demon, charCheck);                
                var symbols = Regex.Matches(demon, symbolsCheck);

                var health = 0;
                double damage = 0;
                foreach (Match letter in chars)
                {
                    var let = letter.Value.ToCharArray();
                    health += let[0];
                }
                foreach (Match number in numbers)
                {
                    var num = number.Value;                        
                    damage += double.Parse(num);
                }
                foreach (Match symbol in symbols)
                {
                    var sym = symbol.Value.ToString();
                    if (sym == "*")
                        damage *= 2;
                    else if (sym == "/")
                        damage /= 2;                    
                }
                result.Add($"{demon} - {health} health, {damage:f2} damage");
            }
            Console.WriteLine(string.Join(Environment.NewLine,result.OrderBy(x=>x)));
        }
    }
}
