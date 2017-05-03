using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sentence_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var delimeter = Console.ReadLine();

            input = input.Replace($"{delimeter}", ", ");

            Console.WriteLine("["+input+"]");
        }
    }
}
