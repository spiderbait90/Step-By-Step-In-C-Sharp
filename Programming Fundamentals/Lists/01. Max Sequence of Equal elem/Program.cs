using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_elem
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var count = 1;
            var maxCount = 1;
            var p = 0;
            var maxP = 0;
            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxP = p;
                        maxCount = count;
                    }
                }
                else
                {
                    p = i+1;
                    count = 1;
                }
            }

            var result = new List<int>();

            for (int i = maxP; i < maxCount+maxP; i++)
            {
                result.Add(list[i]);
            }

            Console.WriteLine(string.Join(" ",result));

            
        }
    }
}
