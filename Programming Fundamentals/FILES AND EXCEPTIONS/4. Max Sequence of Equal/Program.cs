using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Max_Sequence_of_Equal
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            File.WriteAllText("input.txt", input);
            var nums = File.ReadAllText("input.txt")
                .Split().Select(int.Parse).ToList();

            var max = "";
            for (int i = 0; i < nums.Count; i++)
            {
                var current = "";
                for (int a = i; a < nums.Count; a++)
                {
                    if (nums[i] != nums[a])
                        break;
                    else
                        current += " " + nums[i].ToString();
                }
                if (current.Length > max.Length)
                    max = current;
            }
            File.WriteAllText("Output.txt", max.Trim());
        }
    }
}
