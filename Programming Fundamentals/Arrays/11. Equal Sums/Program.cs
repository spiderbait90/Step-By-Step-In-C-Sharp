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
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            for (int left = 0; left < numbers.Length - 2; left++)
            {
                leftSum += numbers[left];
                for (int right = left + 2; right < numbers.Length; right++)
                {
                    if (left == 0)
                        rightSum += numbers[right];
                    else
                    {
                        rightSum -= numbers[left + 1];
                        break;
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(left + 1);
                    return;
                }
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
