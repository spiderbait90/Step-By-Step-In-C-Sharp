using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_of_Capital_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split()
                .ToArray();
            string splittingElements;
            var count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                splittingElements = text[i];
                if(splittingElements.Length==1)
                {
                    var letter2 = char.Parse(splittingElements);
                    if (letter2 >= 65 && letter2 <= 90)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
