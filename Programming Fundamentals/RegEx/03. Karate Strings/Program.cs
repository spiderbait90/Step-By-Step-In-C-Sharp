using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Karate_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@">(\d)([^>]*)");
            var input = Console.ReadLine();
            var matches = regex.Matches(input);            
            var str = new StringBuilder();
            str.Append(input.Split('>').First());
            int strenght=0;
            foreach (Match match in matches)
            {
                strenght += int.Parse(match.Groups[1].Value);
                str.Append
                    (">" + new string(match.Value.Skip(strenght+1).ToArray()));

                strenght -= match.Value.Length-1;
                if (strenght < 0)
                    strenght = 0;
            }
            Console.WriteLine(str.ToString());
        }
    }
}
