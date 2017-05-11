using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();
            var extractDigits = @"\d+";
            var extractElements = @"[^\d]+";
            var uniqueElements = new List<char>();

            var digits = Regex.Matches(input, extractDigits);           
            var elements = Regex.Matches(input, extractElements);
            var listDigits = digits.Cast<Match>()
                .Select(x => x.Value).ToList()
                .Select(int.Parse).ToList();
            var result = new List<string>();
            var count = 0;

            foreach (Match element in elements)
            {
                string str = element.ToString();
                for (int i = 0; i < listDigits[count]; i++)
                {                    
                    result.Add(str.ToUpper());
                }                
                count++;
            }
            foreach (var word in result)
            {
                foreach (var letter in word)
                {
                    uniqueElements.Add(letter);
                }
            }
            Console.WriteLine($"Unique symbols used: {uniqueElements.Distinct().Count()}");
            Console.WriteLine(string.Join("",result));
        }
    }
}
