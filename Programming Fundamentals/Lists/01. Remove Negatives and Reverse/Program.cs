using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            for (int i = numbers.Count-1; i >=0; i--)
            {
                if (numbers[i] < 0)
                    numbers.RemoveAt(i);
            }
           
            numbers.Reverse();
            if (numbers.Count==0)
                Console.WriteLine("empty");
            else
            Console.WriteLine(string.Join(" ",numbers));
            
        }
    }
}
