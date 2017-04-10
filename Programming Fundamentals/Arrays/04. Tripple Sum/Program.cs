using System;
using System.Linq;

namespace _04.Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {                
                for (int i2 = i + 1; i2 < numbers.Length; i2++)
                {
                    for (int i3 = 0; i3 < numbers.Length; i3++)
                    {
                        if (numbers[i] + numbers[i2] == numbers[i3])
                        {
                            Console.WriteLine($"{numbers[i]} + {numbers[i2]} == {numbers[i3]}");
                            counter++;
                        }
                    }                        
                }
            }
            if (counter==0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
