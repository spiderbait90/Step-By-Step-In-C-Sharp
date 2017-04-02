using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_December_2016____Problem_06.Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine());
            var letter2 = char.Parse(Console.ReadLine());
            var letter3 = char.Parse(Console.ReadLine());
            var count = 0;
            for (var a = letter1; a <= letter2; a++)
            {
                for (var b = letter1 ; b <= letter2; b++)
                {
                    for (var c = letter1; c <= letter2; c++)
                    {
                        if (a!=letter3&&b!=letter3&&c!=letter3)
                        {
                            Console.Write($"{a}{b}{c} ");
                            count++;
                        }
                    }
                }
            }
            Console.Write($"{count} ");
        }
    }
}
