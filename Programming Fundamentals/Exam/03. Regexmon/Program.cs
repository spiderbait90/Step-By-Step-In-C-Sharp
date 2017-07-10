using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            var bojo = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");
            var didi = new Regex(@"[^a-zA-Z-]+");
            int index = 0;            
            var isDidi = true;
            while (true)
            {
                var dMatch = didi.Match(str, index);
                if (dMatch.Success && isDidi)
                {
                    Console.WriteLine(dMatch.Value);                   
                    index = dMatch.Index + dMatch.Value.Length;
                    isDidi = false;
                }
                var bMatch = bojo.Match(str, index);
                if (bMatch.Success && !isDidi)
                {
                    Console.WriteLine(bMatch.Value);
                    index = bMatch.Index + bMatch.Value.Length ;
                    isDidi = true;
                }
                if (!bMatch.Success || !dMatch.Success)
                    break;
            }
        }
    }
}

