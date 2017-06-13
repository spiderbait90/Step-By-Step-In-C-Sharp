using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Practice
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new List<Point>();
            for (int i = 0; i < n; i++)
            {
                var currentPoint = new Point();
                var XY = Console.ReadLine().Split();
                currentPoint.X = double.Parse(XY.First());
                currentPoint.Y = double.Parse(XY.Last());
                points.Add(currentPoint);
            }
            var result = FindClosestPoints(points);
            Console.WriteLine($"{result[0]:f3}");
            Console.WriteLine($"({result[1]}, {result[2]})");
            Console.WriteLine($"({result[3]}, {result[4]})");
        }
        public static double[] FindClosestPoints(List<Point> points)
        {
            var minDistance = double.MaxValue;
            var resultPoints = new double[5];
            for (int a = 0; a < points.Count; a++)
            {
                for (int b = a + 1; b < points.Count; b++)
                {
                    var distance = CalcDistance(points[a], points[b]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        resultPoints[0] = minDistance;
                        resultPoints[1] = points[a].X;
                        resultPoints[2] = points[a].Y;
                        resultPoints[3] = points[b].X;
                        resultPoints[4] = points[b].Y;
                    }
                }
            }
            return resultPoints;
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
