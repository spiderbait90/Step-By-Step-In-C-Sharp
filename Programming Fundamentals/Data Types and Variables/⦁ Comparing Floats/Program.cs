using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _____Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var eps = 0.000001; bool lamp;
            var dif = Math.Abs(a - b);
            lamp = (dif <= eps);
            Console.WriteLine(lamp);

        }
    }
}
