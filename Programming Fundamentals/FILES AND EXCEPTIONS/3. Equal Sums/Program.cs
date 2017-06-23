using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            File.WriteAllText("input.txt", input);
            var nums = File.ReadAllText("input.txt")
                .Split().Select(int.Parse).ToList();
            var check = false;
            for (int a = 0; a < nums.Count; a++)
            {
                var leftsum = 0;
                var rightsum = 0;
                for (int b = a+1; b < nums.Count; b++)
                {
                    rightsum += nums[b];
                }
                for (int b = 0; b < a; b++)
                {
                    leftsum += nums[b];
                }
                if (leftsum ==rightsum)
                {
                    File.WriteAllText("Output.txt", a.ToString());
                    check = true;
                    Console.WriteLine(a);
                }
            }
            if(!check)
            {
                File.WriteAllText("Output.txt", "no");
                Console.WriteLine("no");
            }

        }
    }
}
