using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sum = 0;
            for (int i = 1; i < word.Length; i++)
            {
                if (word[i] == 'a') sum += 1;
                if (word[i] == 'e') sum += 2;
                if (word[i] == 'i') sum += 3;
                if (word[i] == 'o') sum += 4;
                if (word[i] == 'u') sum += 5;

            }

            Console.WriteLine(sum);
        }
    }
}
