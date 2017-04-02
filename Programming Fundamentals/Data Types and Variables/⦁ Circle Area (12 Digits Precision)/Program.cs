using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Circle_Area__12_Digits_Precision_
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = double.Parse(Console.ReadLine());

            var area = Math.PI * r * r;
            Console.WriteLine($"{area:f12}");
        }
    }
}
