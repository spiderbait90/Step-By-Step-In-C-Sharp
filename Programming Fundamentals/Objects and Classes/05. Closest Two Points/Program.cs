using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
{
   public class Program
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
        public static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            Point[] closestPoints = FindClosestTwoPoints(points);
            PrintDistance(closestPoints);
            printPoint(closestPoints[0]);
            printPoint(closestPoints[1]);
        }

        private static void printPoint(Point point)
        {
            Console.WriteLine($"({point.X}, {point.Y})");
        }

        private static void PrintDistance(Point[] closestPoints)
        {
            double result = Calculate(closestPoints[0], closestPoints[1]);

            Console.WriteLine($"{result:f3}");
        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;

            Point[] closestPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1+1; p2 < points.Length; p2++)
                {
                    double distance = Calculate(points[p1], points[p2]);
                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints = new Point[] {points[p1],
                        points[p2]};
                    }
                }                
            }
            return closestPoints;
        }

        public static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();                
            }
            return points;
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
        public static double Calculate(Point p1, Point p2)
        {
            var xx = Math.Pow(p1.X - p2.X, 2);
            var yy = Math.Pow(p1.Y - p2.Y, 2);

            var result = Math.Sqrt(xx + yy);
            return result;
        }
    }
}
