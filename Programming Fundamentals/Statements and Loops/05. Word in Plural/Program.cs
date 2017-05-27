using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Word_in_Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();

            if (word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1, 1);
                word += "ies";
            }
            else if (word.EndsWith("o") ||
                word.EndsWith("s") ||
                word.EndsWith("x") ||
                word.EndsWith("z") ||
                word.EndsWith("ch") ||
                word.EndsWith("sh"))
            {
                word += "es";
            }

            else
                word += "s";

            Console.WriteLine(word);
        }
    }
}
