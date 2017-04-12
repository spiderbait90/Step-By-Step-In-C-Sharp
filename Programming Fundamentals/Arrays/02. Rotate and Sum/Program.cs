using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var k = int.Parse(Console.ReadLine());
            var count = k;            
            var sum = new int[numbers.Length];
            
            while (count>0)
            {
                var temp = numbers[numbers.Length - 1];
                for (int i = numbers.Length-1; i >0; i--)
                {
                    numbers[i] = numbers[i-1];
                    for (int i2 = 0; i2 < 1; i2++) ;
                    {
                        sum[i] += numbers[i];
                    }
                }
                numbers[0] = temp;
                sum[0] += numbers[0];
                count--;
            }
            Console.WriteLine(string.Join(" ",sum));


        }
    }
}
