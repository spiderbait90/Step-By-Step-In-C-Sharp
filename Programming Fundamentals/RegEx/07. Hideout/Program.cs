using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (true)
            {
                var arr = Console.ReadLine().Split();
                var escapeReg = Regex.Escape($@"{arr[0]}");
                var match =
                    Regex.Match
                    (input, $@"{escapeReg}{{{int.Parse(arr[1])},}}");

                if (match.Success)
                {
                    Console.WriteLine
                        ($"Hideout found at index {match.Index}" +
                        $" and it is with size {match.Length}!");
                    return;
                }
            }
        }
    }
}
