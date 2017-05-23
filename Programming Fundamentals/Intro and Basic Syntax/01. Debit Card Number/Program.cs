using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var n4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n1:d4} {n2:d4} {n3:d4} {n4:d4}");
        }
    }
}
