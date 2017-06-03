using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var word = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var letter = Console.ReadLine();
                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
