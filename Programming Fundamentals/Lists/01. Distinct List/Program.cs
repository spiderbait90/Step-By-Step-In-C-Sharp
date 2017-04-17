using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distinct_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int a = 0; a < numbers.Count; a++)
            {
                for (int b = a+1; b < numbers.Count; b++)
                {
                    if (numbers[a] == numbers[b])
                    {
                        numbers.RemoveAt(b);
                        b =(a+1)-1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
