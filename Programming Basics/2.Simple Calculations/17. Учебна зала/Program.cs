using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Учебна_зала
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            h *= 100; w *= 100; w -= 100;
            var wide = Math.Floor(w / 70);
            var height = Math.Floor(h / 120);
            var result = (wide * height) - 3;
            Console.WriteLine(result);

        }
    }
}
