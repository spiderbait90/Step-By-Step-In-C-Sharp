using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            numbers.Sort();
            var count = 1;
            int index;
            for (int a = 0; a < numbers.Count; a++)
            {
                for (int b = a+1; b < numbers.Count; b++)
                {
                    if (numbers[a]==numbers[b])
                    {
                        count++;
                        index = b;
                        a = b;
                    }                    
                }                
                Console.WriteLine($"{numbers[a]} -> {count}");
                count = 1;
            }
        }
    }
}
