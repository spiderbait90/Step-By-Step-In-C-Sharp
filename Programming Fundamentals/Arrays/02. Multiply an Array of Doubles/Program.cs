using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var strnumbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToArray();
                
            double p = double.Parse(Console.ReadLine());

            for (int i = 0; i < strnumbers.Length; i++)
            {
                strnumbers[i] *= p;
            }
            Console.WriteLine(string.Join(" ",strnumbers));
            
        }
    }
}
