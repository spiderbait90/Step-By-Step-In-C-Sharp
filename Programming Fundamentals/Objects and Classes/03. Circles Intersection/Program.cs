using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
{
    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
       
    }
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Circle a = ExtractInput();
            Circle b = ExtractInput();
            var distance = CalcDistance(a.Center, b.Center);
            if (distance<=a.Radius+b.Radius)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        public static Circle ExtractInput()
        {
            var input = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            var point = new Point() { X = input[0], Y = input[1] };
            var circle = new Circle() { Center = point, Radius = input[2] };
            return circle;
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
