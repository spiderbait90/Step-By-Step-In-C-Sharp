using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = new Regex(@"^[A-Z][^.]*\.$");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Worm Ipsum")
                    break;
                var match = filter.Match(input);
                if (match.Success)
                {
                    var words = Regex.Matches(input, @"\w+");                 

                    foreach (Match word in words)
                    {
                        var maxCount = 0;
                        char letter = ' ';
                        for (int a = 0; a < word.Value.Length; a++)
                        {
                            var count = 0;
                            for (int b = a; b < word.Length; b++)
                            {
                                if (word.Value[a] == word.Value[b])
                                    count++;
                            }
                            if (count>maxCount)
                            {
                                maxCount = count;
                                letter = word.Value[a];
                            }
                        }
                        if (maxCount > 1)
                            input = input.Replace(word.Value, new string(letter, word.Length));
                    }
                    Console.WriteLine(input);
                }
            }
        }
    }
}
