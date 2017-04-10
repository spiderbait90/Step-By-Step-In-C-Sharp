using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            var count = numbers.Length-1;            
            
            while (count>0)
            {
                var cond = new int[count];
                for (int i = 0; i < count; i++)
                {
                    cond[i] = numbers[i] + numbers[i + 1];

                }
                numbers = cond;
                count--;
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
