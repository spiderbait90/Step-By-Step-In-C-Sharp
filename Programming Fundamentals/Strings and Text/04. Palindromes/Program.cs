using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { ',', '.', '!', '?', ';', ':',' ' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

            var words = new List<string>();

            foreach (var word in text)
            {
                if (word.SequenceEqual(word.Reverse()))
                    words.Add(word);
            }
            Console.WriteLine(string.Join(", ",words.OrderBy(x=>x).Distinct()));
            
        }
    }
}
