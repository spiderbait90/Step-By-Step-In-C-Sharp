using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split();

            SumStringsAndPrint(input[0], input[1]);
        }

        public static void SumStringsAndPrint(string str1, string str2)
        {
            var sum = 0;
            if (str1.Length>=str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (i < str2.Length)
                        sum += (str1[i] * str2[i]);
                    else
                        sum += str1[i];
                }
            }
            else
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    if (i < str1.Length)
                        sum += (str1[i] * str2[i]);
                    else
                        sum += str2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
