using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var regex = new Regex(@"\b[a-zA-Z]\w{2,24}\b");

            var matches = regex.Matches(text);
            var result = new string[2];
            var sum = 0;
            for (int i = 0; i < matches.Count-1; i++)
            {
                if (matches[i].Value.Length +
                    matches[i + 1].Value.Length > sum)
                {
                    sum = matches[i].Value.Length +
                    matches[i + 1].Value.Length;

                    result[0] = matches[i].Value;
                    result[1] = matches[i + 1].Value;
                }
            }

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
