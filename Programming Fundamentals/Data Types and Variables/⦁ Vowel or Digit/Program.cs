using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var check = char.Parse(Console.ReadLine());
            if (check == 'a' || check == 'o' || check == 'u' ||
                check == 'e' || check == 'i')
                Console.WriteLine("vowel");
            else if (char.IsNumber(check))
                Console.WriteLine("digit");
            else Console.WriteLine("other");
            
        }
    }
}
