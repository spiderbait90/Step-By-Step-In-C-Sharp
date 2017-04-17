using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Ununion_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int nTimes = 0; nTimes < n; nTimes++)
            {
                var numbersCheck = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int i = 0; i < numbersCheck.Count; i++)
                {
                    if (primal.Contains(numbersCheck[i]))
                    {
                        while (primal.Contains(numbersCheck[i]))
                        {
                            primal.Remove(numbersCheck[i]);
                        }
                    }
                    else
                    {
                        primal.Add(numbersCheck[i]);
                    }
                }
            }
            primal.Sort();
            Console.WriteLine(string.Join(" ",primal));
        }
    }
}
