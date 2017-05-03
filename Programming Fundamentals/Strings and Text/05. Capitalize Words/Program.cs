using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Capitalize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower();


            while (input != "end")
            {
                var splitWords = input.Split
                    (new[] { ' ', '.', ',', '!', '?', ':', ';', '"', '\n', ']', '[', '{', '}','-' }
                    , StringSplitOptions.RemoveEmptyEntries);

                var list = new List<string>();

                for (int i = 0; i < splitWords.Length; i++)
                {
                    var word = char.ToUpper(splitWords[i][0])
                        .ToString() + splitWords[i].Substring(1);

                    list.Add(word);
                }
                Console.WriteLine(string.Join(", ", list));

                input = Console.ReadLine().ToLower();
            }
        }
    }
}
