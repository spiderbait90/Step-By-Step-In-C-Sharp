using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', '/', '\\', '(', ')' }
                , StringSplitOptions.RemoveEmptyEntries);

            var filter = new Regex(@"\b[a-zA-Z]\w{2,24}\b");
            var result = new List<string>();
            foreach (var word in input)
            {
                var match = filter.Match(word);
                if (match.Success)
                    result.Add(match.Value);
            }
            var max = 0;
            var word1 = "";
            var word2 = "";
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i].Length +
                    result[i + 1].Length > max)
                {
                    max = result[i].Length +
                                        result[i + 1].Length;
                    word1 = result[i];
                    word2 = result[i + 1];
                }
            }
            Console.WriteLine(word1);
            Console.WriteLine(word2);
        }
    }
}
