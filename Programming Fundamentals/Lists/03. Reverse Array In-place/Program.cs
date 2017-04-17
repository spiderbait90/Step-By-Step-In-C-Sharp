using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Reverse_Array_In_place
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length/2; i++)
            {                
                var temp = numbers[i];
                numbers[i] = numbers[(numbers.Length - 1) - i];
                numbers[(numbers.Length - 1) - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        
    }
}
