using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace _______Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountPics = double.Parse(Console.ReadLine());
            var sec = double.Parse(Console.ReadLine());
            var percGood = double.Parse(Console.ReadLine());
            var timeToUpload = double.Parse(Console.ReadLine());
            percGood /= 100;
            var filtPic = Math.Ceiling(amountPics * percGood);
            var filtTimeSec = amountPics * sec;
            var uploadTimeSec = filtPic * timeToUpload;
            var totalTimeSec = filtTimeSec + uploadTimeSec;

            CultureInfo provider = CultureInfo.InvariantCulture;
            
            var time = TimeSpan.FromSeconds(totalTimeSec);
            var str = time.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(str);

        }
    }
}
