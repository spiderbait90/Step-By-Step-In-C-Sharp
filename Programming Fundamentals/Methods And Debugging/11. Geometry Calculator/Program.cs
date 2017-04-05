using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            if (figure == "triangle")
            {
                var side = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Triangle(side, height):f2}");
            }
            else if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Square(side):f2}");
            }
            else if (figure == "rectangle")
            {
                var width = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Rectangle(width, height):f2}");
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{Circle(radius):f2}");
                
            }

        }
        static double Triangle(double side, double heigh)
        {
            return side / 2 * heigh;
        }
        static double Square(double side)
        {
            return side * side;
        }
        static double Rectangle(double width, double height)
        {
            return width * height;
        }
        static double Circle(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
