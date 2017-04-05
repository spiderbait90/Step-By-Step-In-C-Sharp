using System;
using System.Collections.Generic;

namespace _08.Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var distance1 = Cordinates(x1, y1);
            var distance2 = Cordinates(x2, y2);
            var list = new List<double>();
            

            if (distance1 > distance2)
            {
                list.Add(x2); list.Add(y2);
            }
            else if (distance1 < distance2)
            {
                list.Add(x1); list.Add(y1);
            }
            else if (distance1 == distance2)
            {
                list.Add(x1); list.Add(y1);
            }
            Console.Write("(");
            Console.Write(string.Join(", ", list));
            Console.WriteLine(")");

        }

        static double Cordinates(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) +
                Math.Pow(y, 2));
            return distance;

        }
    }
}
