using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var reverseN = Reverse(n);
            Console.WriteLine(reverseN);
        }

        private static double Reverse(string n)
        {
            string reverse = "";

            foreach (var item in n)
            {
                reverse = item + reverse;
            }

            return double.Parse(reverse);
        }
    }
}
