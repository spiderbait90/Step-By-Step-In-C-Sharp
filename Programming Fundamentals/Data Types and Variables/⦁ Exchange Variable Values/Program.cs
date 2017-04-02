using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            Console.WriteLine($"Before:\na = {a}\nb = {b}");
            var temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\na = {a}\nb = {b}");

        }
    }
}
