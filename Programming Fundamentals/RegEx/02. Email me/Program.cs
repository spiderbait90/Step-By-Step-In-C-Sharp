using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Email_me
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var match = Regex.Match(email, $"(.+)@(.+)");            
            var sumAfter = match.Groups[2].Value.Sum(x => x);
            var sumBefore = match.Groups[1].Value.Sum(x => x);            
            
            if (sumAfter-sumBefore<=0)
                Console.WriteLine("Call her!");
            else
                Console.WriteLine("She is not the one.");
        }
    }
}
