using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string element = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            string collect = "";
            for (int i = 1; i < n; i++)
            {
                var word = Console.ReadLine();
                collect += word + element;
            }
            var wordlast = Console.ReadLine();
            collect += wordlast;
            Console.WriteLine(collect);


        }
    }
}
