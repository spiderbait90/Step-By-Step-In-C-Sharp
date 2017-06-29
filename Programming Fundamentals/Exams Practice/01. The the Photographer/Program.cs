using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.The_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var ft = long.Parse(Console.ReadLine());
            var ff = long.Parse(Console.ReadLine());
            var ut = long.Parse(Console.ReadLine());

            var filteredPics = Math.Ceiling(n * ((double)ff / 100));
            var seconds = n * ft;
            var moreSeconds = filteredPics * ut;
            var totalTime = seconds + (long)moreSeconds;
            var ss = totalTime % 60;
            var mm = (totalTime / 60) % 60;
            var hh = ((totalTime / 60) / 60) % 24;
            var d = ((totalTime / 60) / 60) / 24;
            Console.WriteLine($"{d:d1}:{hh:d2}:{mm:d2}:{ss:d2}");
        }
    }
}
