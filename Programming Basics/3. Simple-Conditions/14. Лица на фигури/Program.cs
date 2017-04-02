using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Лица_на_фигури
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var result = a * a;
                Console.WriteLine(result);
            }
            else if (figure == "triangle")
            {
                var h = double.Parse(Console.ReadLine());
                var s = double.Parse(Console.ReadLine());
                var result = h * s / 2;
                Console.WriteLine(result);
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                var result = Math.PI * r * r;
                Console.WriteLine(Math.Round(result,3));
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var result = a * b;
                Console.WriteLine(result);
            }



        }
    }
}
