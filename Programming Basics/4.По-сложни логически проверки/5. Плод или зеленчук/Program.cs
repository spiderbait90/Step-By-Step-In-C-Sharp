using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Плод_или_зеленчук
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().ToLower();
            if (x=="banana"|| x == "kiwi"|| x == "apple" || x == "cherry" || x == "lemon" || x == "grapes")
            Console.WriteLine("fruit");
            else if (x == "tomato" || x == "cucumber" || x == "pepper" || x == "carrot")
            Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");

        }
    }
}
