using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Happiness_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var happy = @"(:|;)(\)|D|\*|]|})|(\(|\*|\[|{|c)(;|:)";
            var sad = @"(:|;)(\(|\[|{|c)|(D|\)|])(:|;)";

            var happyMatches = Regex.Matches(input, happy);
            var sadMatches = Regex.Matches(input, sad);
            var faceIndex = "";
            double result = (double)happyMatches.Count / (double)sadMatches.Count;

            if (result >= 2)
                faceIndex = ":D";
            else if (result > 1)
                faceIndex = ":)";
            else if (result == 1)
                faceIndex = ":|";
            else if (result < 1)
                faceIndex = ":(";

            Console.WriteLine($"Happiness index: {result:f2} {faceIndex}");
            Console.WriteLine($"[Happy count: {happyMatches.Count}," +
                $" Sad count: {sadMatches.Count}]");
        }
    }
}
