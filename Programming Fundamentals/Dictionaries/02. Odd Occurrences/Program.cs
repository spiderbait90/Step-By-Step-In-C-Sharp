using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if(count.ContainsKey(word))
                {
                    count[word]++;
                }
                else
                {
                    count[word] = 1;
                }
            }
            var result = new List<string>();
            foreach (var key in count)
            {
                if (key.Value%2!=0)
                {
                    result.Add(key.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
