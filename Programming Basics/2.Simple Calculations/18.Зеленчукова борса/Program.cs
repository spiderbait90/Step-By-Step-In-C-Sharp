using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            double PriceVeg = double.Parse(Console.ReadLine());
            double PriceFruit = double.Parse(Console.ReadLine());
            double KgVeg = double.Parse(Console.ReadLine());
            double KgFruit = double.Parse(Console.ReadLine());
            double Veg = PriceVeg * KgVeg;
            double Fruit = PriceFruit * KgFruit;
            double result = Fruit + Veg;
            double result2 = result / 1.94;
            Console.WriteLine(result2);


        }
    }
}
