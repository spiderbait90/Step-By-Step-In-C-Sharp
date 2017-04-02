using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Reverse_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter1 = char.Parse(Console.ReadLine());
            var letter2 = char.Parse(Console.ReadLine());
            var letter3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{letter3}{letter2}{letter1}");
        }
    }
}
