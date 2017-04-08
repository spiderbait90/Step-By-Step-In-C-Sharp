using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_of_Given_Element_in_Arry
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            var check = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] == check)
                    count++;
            }
            Console.WriteLine(count);

        }
    }
}
