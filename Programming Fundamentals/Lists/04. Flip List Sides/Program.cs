using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Flip_List_Sides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            for (int i = 1; i < numbers.Count-2; i++)
            {
                numbers.Insert(i, numbers[numbers.Count-2]);
                numbers.RemoveAt(numbers.Count - 2);
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
