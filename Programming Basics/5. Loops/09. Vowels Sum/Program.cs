using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a') sum += 1;
                if (s[i] == 'e') sum += 2;
                if (s[i] == 'i') sum += 3;
                if (s[i] == 'o') sum += 4;
                if (s[i] == 'u') sum += 5;
            }
            Console.WriteLine(sum);
        }
    }
}
