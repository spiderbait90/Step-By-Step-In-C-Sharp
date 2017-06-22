using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_sentences_by_key
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var regex = new Regex($@"[^?.!]+({word}) [^?.!]+");

            var matches = regex.Matches(text);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
