using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_and_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var OddSum = 0.0;  var EvenSum = 0.0;
            var OddMin = 1000000000.0;  var EvenMin = 1000000000.0;
            var OddMax = -1000000000.0;  var EvenMax = -1000000000.0;
            for (var i=1;i<= n;i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += num;
                    if (num > EvenMax) EvenMax = num;                    
                    if (num < EvenMin) EvenMin = num;                    
                }
                else if (i % 2 != 0)
                {
                    OddSum += num;
                    if (num > OddMax) OddMax = num;                    
                    if (num < OddMin) OddMin = num;                    
                }

            }
            Console.Write($"OddSum = {OddSum},");
            if (OddMin == 1000000000.0) Console.Write("OddMin = No,");
            else Console.Write($"OddMin = {OddMin},");
            if (OddMax == -1000000000.0) Console.Write($"OddMax = No,");
            else Console.Write($"OddMax = {OddMax},");
            Console.Write($"EvenSum = {EvenSum},");
            if (EvenMin == 1000000000.0) Console.Write("EvenMin = No,");
            else Console.Write($"EvenMin = {EvenMin},");
            if (EvenMax == -1000000000.0) Console.Write($"EvenMax = No,");
            else Console.Write($"EvenMax = {EvenMax},");
        }
    }
}
