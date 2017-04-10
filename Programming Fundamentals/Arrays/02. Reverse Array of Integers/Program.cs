using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Console.ReadLine();
                
            }
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
            
            
        }
    }
}
