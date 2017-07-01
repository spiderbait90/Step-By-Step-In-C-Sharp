using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Camera_View
{
    class Program
    {
        static void Main(string[] args)
        {
            var skipTake = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var text = Console.ReadLine();
            var skip = skipTake[0];
            var take = skipTake[1];

            var matches = Regex.Matches(text, @"\|<([^|]+)");
            var result = new List<string>();
            foreach (Match match in matches)
            {
                result.Add
                    (new string(match.Groups[1].Value.Skip(skip).Take(take).ToArray()));
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
