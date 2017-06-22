using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = BigInteger.Parse(Console.ReadLine());
            var n2 = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(n1 * n2);
        }
    }
}
