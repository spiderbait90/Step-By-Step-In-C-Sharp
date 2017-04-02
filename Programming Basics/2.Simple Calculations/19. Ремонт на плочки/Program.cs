using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Ремонт_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double AllSpace = N * N;
            double Bench = M * O;
            double Space = AllSpace - Bench;
            double PlateSpace = W * L;
            double NeededPlate = Space / PlateSpace;
            double Result = NeededPlate * 0.2;
            Console.WriteLine(NeededPlate);
            Console.WriteLine(Result);
            



        }
    }
}
