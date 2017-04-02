using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            var Sign = Console.ReadLine();
            
            if (Sign=="+")
            {
                var result = N1 + N2;
                if (result % 2 == 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - even");
                else if (result % 2 != 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - odd");
            }
            else if (Sign == "-")
            {
                var result = N1 - N2;
                if (result % 2 == 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - even");
                else if (result % 2 != 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - odd");
            }
            else if (Sign == "*")
            {
                var result = N1 * N2;
                if (result % 2 == 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - even");
                else if (result % 2 != 0) Console.WriteLine($"{N1} {Sign} {N2} = {result} - odd");
            }
            else if (Sign=="/")
            {
                if (N2 > 0)
                {
                    var result = N1 / N2;
                    Console.WriteLine($"{N1} {Sign} {N2} = {result:f2}");
                }
                else if (N2==0) Console.WriteLine($"Cannot divide {N1} by zero");
            }
            else if (Sign == "%")
            {
                if (N2 > 0)
                {
                    var result = N1 % N2;
                    Console.WriteLine($"{N1} {Sign} {N2} = {result}");
                }
                else if (N2==0) Console.WriteLine($"Cannot divide {N1} by zero");
            }
        }
    }
}
