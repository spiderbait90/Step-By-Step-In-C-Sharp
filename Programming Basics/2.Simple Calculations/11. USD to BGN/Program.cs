using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.USD_to_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 USD = 1.79549 BGN.
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn,2));
        }
    }
}
