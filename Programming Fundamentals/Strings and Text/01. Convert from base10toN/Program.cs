using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base10toN
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();

            var n = input[0];
            var num = input[1];
            var result = "";
            while (num!=0)
            {
                result =  num % n+result;
                num /= n;
            }
            
            Console.WriteLine(result);
        }
    }
}
