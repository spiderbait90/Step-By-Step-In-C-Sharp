using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.English_Name_of_D
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var result = LastDigit(a);
            Console.WriteLine(result);
        }

        private static string LastDigit(long a)
        {
            var digit = Math.Abs(a % 10);
            var word = "";
            switch (digit)
            {
                case 1: word = "one"; break;
                case 2: word = "two"; break;
                case 3: word = "three"; break;
                case 4: word = "four"; break;
                case 5: word = "five"; break;
                case 6: word = "six"; break;
                case 7: word = "seven"; break;
                case 8: word = "eight"; break;
                case 9: word = "nine"; break;
                case 0: word = "zero"; break;
            }
            return word;
        }
    }
}
