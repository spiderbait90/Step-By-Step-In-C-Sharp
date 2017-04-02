using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Excellent_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            if (N >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
            else 
            {
                Console.WriteLine("Not excellent.");
            }
        }
    }
}
