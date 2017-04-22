using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mixed_Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ':',' ' }, StringSplitOptions.RemoveEmptyEntries);
            var phoneBook = new SortedDictionary<string, long>();
            while (input.Length>1)
            {
                long parsed = 0;
                if (long.TryParse(input[1],out parsed ))
                {
                    phoneBook[input[0]] = parsed;
                }
                else
                {
                    phoneBook[input[1]] = long.Parse(input[0]);
                }
                input = Console.ReadLine()
                .Split(new[] { ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var kv in phoneBook)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
    }
}
