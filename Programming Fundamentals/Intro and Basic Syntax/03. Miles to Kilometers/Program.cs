using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            var miles = decimal.Parse(Console.ReadLine());
            var result = miles * (decimal)1.60934;
            Console.WriteLine($"{result:f2}");
        }
    }
}
