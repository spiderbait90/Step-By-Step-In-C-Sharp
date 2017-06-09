using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            var num = int.Parse(Console.ReadLine());
            
            var index = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                    index = i;
            }

            if (index==-1)
                Console.WriteLine("No occurrences were found!");
            else
            {
                long sum = 0;
                for (int i = 0; i < index; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
