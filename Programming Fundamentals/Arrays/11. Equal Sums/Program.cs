using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                           .Select(int.Parse).ToArray();

            var index = -1;
            for (int a = 0; a < numbers.Length; a++)
            {
                var rightSum = 0;
                for (int right = a + 1; right < numbers.Length; right++)
                {
                    rightSum += numbers[right];
                }
                var leftSum = 0;
                for (int left = a - 1; left >= 0; left--)
                {
                    leftSum += numbers[left];
                }
                if (leftSum == rightSum)
                    index = a;

            }
            if (index == -1)
                Console.WriteLine("no");
            else
                Console.WriteLine(index);
        }
    }
}
