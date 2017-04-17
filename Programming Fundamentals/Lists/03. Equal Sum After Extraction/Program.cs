using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Equal_Sum_After_Extraction
{
	class Program
	{
		static void Main(string[] args)
		{
            var firstList = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            var secondList = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < secondList.Count; i++)
            {
                if (firstList.Contains(secondList[i]))
                {
                    secondList.Remove(secondList[i]);
                    i = -1;
                }
            }
            var sum1 = firstList.Sum();
            var sum2 = secondList.Sum();
            if (sum1==sum2)
                Console.WriteLine($"Yes. Sum: {sum1}");
            else
            {
                var diff = Math.Abs(sum1-sum2);
                Console.WriteLine($"No. Diff: {diff}");
            }
        }
	}
}
