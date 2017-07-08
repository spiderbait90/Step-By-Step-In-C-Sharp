using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var wormLenghtM = decimal.Parse(Console.ReadLine());
            var wormWidthCM = decimal.Parse(Console.ReadLine());
            wormLenghtM *= 100;
            decimal remainder;
            try
            {
                remainder = wormLenghtM % wormWidthCM;
            }
            catch (Exception)
            {
                remainder = 0;
            }
            if (remainder!=0)
                Console.WriteLine($"{(wormLenghtM/wormWidthCM)*100:f2}%");
            else
                Console.WriteLine($"{wormLenghtM*wormWidthCM:f2}");
        }
    }
}
