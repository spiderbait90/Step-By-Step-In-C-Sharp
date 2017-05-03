using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            while (input != "end")
            {
                var pattern = @"<a.*?href.*?=(.*)>(.*?)</a>";
                var replace = @"[URL href=$1]$2[/URL]";
                var replaced = Regex.Replace(input, pattern, replace);
                Console.WriteLine(replaced);
                input = Console.ReadLine();
            }
        }
    }
}
