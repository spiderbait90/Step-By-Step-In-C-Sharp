using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = $"Name: DSC_{int.Parse(Console.ReadLine()):d4}.jpg";

            var date = $"Date Taken: {int.Parse(Console.ReadLine()):d2}/" +
                $"{int.Parse(Console.ReadLine()):d2}/{int.Parse(Console.ReadLine()):d4} " +
                $"{int.Parse(Console.ReadLine()):d2}:{int.Parse(Console.ReadLine()):d2}";

            var bytes = long.Parse(Console.ReadLine());
            var size = $"Size: ";

            if (bytes < 1024)
                size += $"{bytes}B";
            else if (bytes < 1000 * 1000)
                size += $"{bytes * 0.001}KB";
            else
                size += $"{bytes * 0.000001}MB";

            var width = int.Parse(Console.ReadLine());
            var heidth = int.Parse(Console.ReadLine());

            var resolution = $"Resolution: {width}x{heidth} ";

            if (width == heidth)
                resolution += "(square)";
            else if (width > heidth)
                resolution += "(landscape)";
            else
                resolution += "(portrait)";

            Console.WriteLine(name);
            Console.WriteLine(date);
            Console.WriteLine(size);
            Console.WriteLine(resolution);
        }
    }
}
