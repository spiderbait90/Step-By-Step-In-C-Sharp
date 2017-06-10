using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Numerics;

namespace Practice
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Point();
            var p2 = new Point();
            var firstPoint = Console.ReadLine().Split();
            var secondPoint = Console.ReadLine().Split();
            p1.X = double.Parse(firstPoint[0]);
            p1.Y = double.Parse(firstPoint[1]);
            p2.X = double.Parse(secondPoint[0]);
            p2.Y = double.Parse(secondPoint[1]);

            var result = CalcDistance(p1, p2);
            Console.WriteLine($"{result:f3}");
        }

        public static double CalcDistance(Point p1, Point p2)
        {
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }
    }
}
