using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Парички
{
    class Program
    {
        static void Main(string[] args)
        {
            double Bit = double.Parse(Console.ReadLine());
            double CNY = double.Parse(Console.ReadLine());
            double Comision = double.Parse(Console.ReadLine());
            double Leva = Bit * 1168 + CNY * 0.264;
            double Evro = Leva / 1.95;
            double ComisionUnit = Comision / 100 * Evro;
            double ResultConvert = Evro - ComisionUnit;
            Console.WriteLine(ResultConvert);
        }
    }
}
