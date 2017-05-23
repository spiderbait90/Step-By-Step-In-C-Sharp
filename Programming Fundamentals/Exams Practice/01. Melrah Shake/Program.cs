using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var word = Console.ReadLine();
            var escapedPatern = Regex.Escape(word);
            var pattern = new Regex(escapedPatern);
            
            while (true)
            {                                
                var matches = pattern.Matches(text);
                
                if (matches.Count < 2 || word.Length == 0)
                {
                    break;
                }

                var firstIndex = text.IndexOf(word);
                text = text.Remove(firstIndex, word.Length);
                var lastIndex = text.LastIndexOf(word);
                text = text.Remove(lastIndex, word.Length);

                word = word.Remove(word.Length / 2, 1);
                escapedPatern = Regex.Escape(word);
                pattern = new Regex(escapedPatern);

                Console.WriteLine("Shaked it.");
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}
