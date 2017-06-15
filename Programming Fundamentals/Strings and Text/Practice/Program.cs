using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '!', '?' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(x => x)
                .Where(x=>new string(x.Reverse().ToArray())==x)
                .ToList();

            Console.WriteLine(string.Join(", ",text));
        }
    }
}
