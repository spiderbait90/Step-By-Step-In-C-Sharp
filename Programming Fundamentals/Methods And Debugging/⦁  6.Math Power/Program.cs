using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ___6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPowe(a,b));
            
        }
        static double MathPowe(double a,double b)
        {
            var result = Math.Pow(a, b);
            return result;
        }
    }
}
