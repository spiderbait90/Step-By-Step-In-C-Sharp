using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string>();
            while (true)
            {
                var code = Console.ReadLine();
                if (code == "Over!")
                    break;
                var n = int.Parse(Console.ReadLine());
                var regex = new Regex($@"(^\d+)([a-zA-Z]{{{n}}})([^a-zA-Z]*$)");
                var match = regex.Match(code);
                if (match.Success)
                {
                    var searchDigit = match.Groups[1].Value +
                        match.Groups[3].Value;
                    var verification = "";
                    foreach (var item in searchDigit)
                    {
                        if (char.IsDigit(item))
                        {
                            var index = int.Parse(item.ToString());
                            if (index >= 0 && index < match.Groups[2].Value.Length)
                                verification += match.Groups[2].Value[index];
                            else
                                verification += " ";
                        }
                    }
                    result.Add($"{match.Groups[2].Value} == {verification}");
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
