using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            double max = -100000;
            for (var i=1;i<= n;i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
            }
            Console.WriteLine(max);
        }
    }
}
