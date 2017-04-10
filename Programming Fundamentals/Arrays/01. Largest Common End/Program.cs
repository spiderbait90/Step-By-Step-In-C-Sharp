using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = Console.ReadLine().Split(' ').ToArray();
            var text2 = Console.ReadLine().Split(' ').ToArray();
            long result;
            if (LeftToRight(text1, text2) >= RightToLeft(text1, text2))
                result = LeftToRight(text1, text2);
            else
                result = RightToLeft(text1, text2);
            Console.WriteLine(result);


        }
        static long LeftToRight(string[] text1, string[] text2)
        {
            var smallest = Math.Min(text1.Length, text2.Length);
            var count = 0;
            var max = 0;
            for (int i = 0; i < smallest; i++)
            {
                if (text1[i] == text2[i])
                {
                    count++;
                    if (count > max)
                        max = count;
                }
                else
                    break;
            }
            return max;
        }
        static long RightToLeft(string[] text1, string[] text2)
        {
            var smallest = Math.Min(text1.Length, text2.Length);
            var bigger = Math.Max(text1.Length, text2.Length);
            var count = 0;
            var max = 0;
            for (int i = smallest - 1; i >= 0; i--)
            {
                if (text1.Length >= text2.Length)
                {
                    if (text1[(bigger - 1)] == text2[i])
                    {
                        count++;
                        if (count > max)
                            max = count;
                    }
                    else
                        break;
                }
                else if (text1.Length < text2.Length)
                {
                    if (text1[i] == text2[bigger - 1])
                    {
                        count++;
                        if (count > max)
                            max = count;
                    }
                    else
                        break;
                }
                bigger--;
            }
            return max;
        }

    }
}
