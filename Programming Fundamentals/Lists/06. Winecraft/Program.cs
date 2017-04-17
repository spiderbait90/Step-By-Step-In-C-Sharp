using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());
            while (numbers.Count>=n)
            {
                for (int rounds = 0; rounds < n; rounds++)
                {
                    for (int i = 1; i < numbers.Count - 1; i++)
                    {
                        if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1])
                        {
                            if (numbers[i + 1]>0&& numbers[i - 1]>0)
                            {
                                numbers[i] += 2;
                                numbers[i - 1]--;
                                numbers[i + 1]--;
                                i++;
                            }
                            else if (numbers[i + 1] < 1 && numbers[i - 1] <1)
                            {
                                i++;
                            }
                            else if (numbers[i + 1] > 0 && numbers[i - 1] < 1)
                            {
                                numbers[i] += 1;
                                numbers[i + 1]--;
                                i++;
                            }
                            else if (numbers[i + 1] < 1 && numbers[i - 1] > 0)
                            {
                                numbers[i] += 1;
                                numbers[i - 1]--;
                                i++;
                            }
                            if (i == numbers.Count - 2)
                            {
                                numbers[numbers.Count - 1]++;
                            }
                        }
                        else
                        {
                            numbers[i - 1]++;
                        }
                    }
                }
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i]<=n)
                    {
                        numbers.RemoveAt(i);
                        i--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
