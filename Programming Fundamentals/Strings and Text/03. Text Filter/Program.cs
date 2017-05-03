using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ' ', ',' },
                StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            for (int i = 0; i < bannedWords.Length; i++)
            {
                text = text.Replace(bannedWords[i],
                    $"{new string('*', bannedWords[i].Length)}");
            }
            Console.WriteLine(text);
        }
    }
}
