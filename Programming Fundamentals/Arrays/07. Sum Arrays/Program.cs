using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var numbers2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();            
            var bigger = Math.Max(numbers1.Length, numbers2.Length);
            var smaller = Math.Min(numbers1.Length, numbers2.Length);
            var result = new int[bigger];
            for (int i = 0; i < bigger; i++)
            {
                result[i] = 
                    numbers1[i%numbers1.Length]
                    + numbers2[i%numbers2.Length];
               
            }
            
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
