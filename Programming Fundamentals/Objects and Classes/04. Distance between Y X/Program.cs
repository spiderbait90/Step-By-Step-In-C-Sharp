using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Y_X
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = ReadPoint();
            var p2 = ReadPoint();

            double distance = Calculate(p1, p2);

            Console.WriteLine($"{distance:f3}");

        }

        public static double Calculate(Point p1, Point p2)
        {
            var xx = Math.Pow(p1.X - p2.X, 2);
            var yy = Math.Pow(p1.Y - p2.Y, 2);

            var result = Math.Sqrt(xx + yy);
            return result;
        }

        public static Point ReadPoint()
        {
            var input = Console.ReadLine().Split(' ')
                            .Select(double.Parse).ToArray();

            var point = new Point();

            point.X = input[0];
            point.Y = input[1];
            return point;
        }
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}
