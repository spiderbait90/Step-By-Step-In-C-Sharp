using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var letter = "ACGT";
            var count = 0;
            for (int a = 0; a < letter.Length; a++)
            {
                for (int b = 0; b < letter.Length; b++)
                {
                    for (int c = 0; c < letter.Length; c++)
                    {
                        if ((a+1)+(b+1)+(c+1)>=n)
                            Console.Write($"O{letter[a]}{letter[b]}{letter[c]}O");
                        else
                            Console.Write($"X{letter[a]}{letter[b]}{letter[c]}X");
                        count++;

                        if (count%4!=0)
                            Console.Write(" ");
                        
                        if (count%4==0)
                            Console.WriteLine();
                    }
                }
            }
        }
    }
}
