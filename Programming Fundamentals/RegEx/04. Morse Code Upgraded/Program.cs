using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Morse_Code_Upgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split('|').ToArray();
            var result = new StringBuilder();
            var regexConsec = new Regex(@"(1+)|(0+)");

            foreach (var code in input)
            {
                int sum = 0;
                for (int i = 0; i < code.Length; i++)
                {
                    if (code[i] == '1')
                    {
                        sum += 5;
                    }
                    else if (code[i] == '0')
                    {
                        sum += 3;
                    }
                }
                var matches = regexConsec.Matches(code);

                foreach (Match match in matches)
                {
                    if (match.Groups[1].Value.Length > 1)
                        sum += match.Groups[1].Value.Length;
                    if (match.Groups[2].Value.Length > 1)
                        sum += match.Groups[2].Value.Length;
                }
                result.Append((char)sum);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
