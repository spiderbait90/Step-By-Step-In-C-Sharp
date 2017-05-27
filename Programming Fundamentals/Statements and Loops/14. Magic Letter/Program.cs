using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine());
            var letter2 = char.Parse(Console.ReadLine());
            var letterX = char.Parse(Console.ReadLine());

            for (char a = letter1; a <=letter2; a++)
            {
                for (char b = letter1; b <= letter2; b++)
                {
                    for (char c = letter1; c <= letter2; c++)
                    {
                        if (a==letterX||b==letterX||c==letterX)
                        {

                        }
                        else
                            Console.Write($"{a}{b}{c} ");
                    }
                }
            }
        }
    }
}
