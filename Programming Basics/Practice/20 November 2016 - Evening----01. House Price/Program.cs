using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_November_2016___Evening____01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var SmallestRoom = double.Parse(Console.ReadLine());
            var Kitchen = double.Parse(Console.ReadLine());
            var CostSquareM = double.Parse(Console.ReadLine());

            double SecondRoom = SmallestRoom + (SmallestRoom * 0.10);
            double ThirdRoom = SecondRoom + (SecondRoom * 0.10);
            double bathroom = SmallestRoom / 2;
            double total = SmallestRoom + Kitchen + SecondRoom + ThirdRoom + bathroom;
            total += (total * 0.05);
            double final = total * CostSquareM;
            Console.WriteLine($"{final:f2}");
        }
    }
}
