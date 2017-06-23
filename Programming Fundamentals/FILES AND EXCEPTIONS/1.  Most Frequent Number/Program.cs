using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            File.WriteAllText("input.txt", input);
            var nums = File.ReadAllText("input.txt").Split()
                .Select(int.Parse).ToArray();

            var max = 0;            
            var num = 0;
            for (int a = 0; a < nums.Length; a++)
            {
                var count = 0;
                for (int b = 0; b < nums.Length; b++)
                {
                    if (nums[a] == nums[b])
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    num = nums[a];
                }
            }
            File.WriteAllText("Outut.txt", num.ToString());
        }
    }
}
