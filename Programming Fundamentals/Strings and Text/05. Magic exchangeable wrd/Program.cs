using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_wrd
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split();

            CheckIfMagic(input[0], input[1]);
        }

        public static void CheckIfMagic(string v1, string v2)
        {
            var str1 = v1.Distinct().ToArray();
            var str2 = v2.Distinct().ToArray();

            if (str1.Length==str2.Length)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
