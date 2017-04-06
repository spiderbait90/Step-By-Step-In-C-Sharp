using System;
using System.Collections.Generic;

namespace Practice__
{
    class Program
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var distance1 = CenterPoint(x1, y1);
            var distance2 = CenterPoint(x2, y2);
            var distance3 = CenterPoint(x3, y3);
            var distance4 = CenterPoint(x4, y4);

            var line1 = distance1 + distance2;
            var line2 = distance3 + distance4;

            if (line1 >= line2)
            {
                if (distance1 <= distance2)
                {
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (distance3 <= distance4)
                {
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                }
                else
                {
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                }
            }
        }

        static double CenterPoint(double x, double y)
        {
            var result = Math.Sqrt(Math.Pow((x), 2) +
                Math.Pow((y), 2));
            return result;

        }
    }
}
