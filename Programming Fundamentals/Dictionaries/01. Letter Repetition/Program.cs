using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Letter_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = Console.ReadLine().ToCharArray();

            var count = new Dictionary<char, int>();

            foreach (var letter in letters)
            {
                if (count.ContainsKey(letter))
                {
                    count[letter]++;
                }
                else
                {
                    count[letter] = 1;
                }
            }
            foreach (var kv in count)
            {
                Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
                
        }
    }
}
