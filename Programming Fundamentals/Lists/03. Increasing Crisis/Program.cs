using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Increasing_Crisis
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var n = int.Parse(Console.ReadLine());
            for (int a = 0; a < n; a++)
            {
                var numbers = Console.ReadLine()
                    .Split(' ').Select(int.Parse)
                    .ToList();
                if (list.Count == 0)
                {
                    list = numbers;
                }
                else
                {
                    for (int i = 0; i < list.Count - 1; i++)
                    {
                        if (numbers[0] >= list[i] && numbers[0] < list[i + 1])
                        {                            
                            for (int c = 0; c < numbers.Count; c++)
                            {
                                list.Insert(i + 1+c, numbers[c]);
                            }
                            break;
                        }
                        else if (numbers[0]>=list[list.Count-1])
                        {
                            for (int c = 0; c < numbers.Count; c++)
                            {
                                list.Add(numbers[c]);
                            }
                            break;
                        }
                        else if (numbers[0]<list[0])
                        {
                            for (int c = 0; c < numbers.Count; c++)
                            {
                                list.Insert(i + c, numbers[c]);
                            }
                            break;
                        }                                
                    }
                    if (list.Count == 1)
                    {
                        if (numbers[0] >= list[0])
                        {
                            for (int r = 0; r < numbers.Count; r++)
                            {
                                list.Add(numbers[r]);
                            }
                        }
                        else if (numbers[0] < list[0])
                        {
                            for (int r = 0; r < numbers.Count; r++)
                            {
                                list.Insert(r, numbers[r]);
                            }
                        }
                    }
                }
                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list[i + 1] < list[i])
                        list.RemoveRange(i + 1, list.Count-(i+1));
                }
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
