using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inherated = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            double sum = inherated;
            var years = 17;

            for (int i = 1800; i <= year; i++)
            {
                years++;
                if (i%2==0)
                {
                    sum -= 12000;
                }
                else if (i%2!=0)
                {
                    sum -= 12000 + 50 * years;
                }
            }
            if (sum >= 0) Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", sum);
            else if (sum < 0) Console.WriteLine("He will need {0:f2} dollars to survive.",Math.Abs(sum));
        }
    }
}
