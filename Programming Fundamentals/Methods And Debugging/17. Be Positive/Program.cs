using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Be_Positive
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                    .ToList();
                var result = new List<int>();

                for (int j = 0; j < numbers.Count; j++)
                {
                    int currentNum = numbers[j];

                    if (currentNum >= 0)
                    {
                        result.Add(currentNum);
                    }
                    else
                    {
                        try
                        {
                            currentNum = numbers[j] + numbers[j + 1];
                        }
                        catch
                        {

                        }
                        if (currentNum >= 0)
                        {
                            result.Add(currentNum);
                        }
                        j++;
                    }
                }

                if (result.Count == 0)
                {
                    Console.WriteLine("(empty)");
                }
                else
                    Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
