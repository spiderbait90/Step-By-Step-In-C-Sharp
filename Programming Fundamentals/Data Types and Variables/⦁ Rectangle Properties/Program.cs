using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = 2 * width + 2 * height;
            double diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(width, 2));
            Console.WriteLine($"{perimeter}\n{area}\n{diagonal}");
        }
    }
}
