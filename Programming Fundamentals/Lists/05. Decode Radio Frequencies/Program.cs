using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Decode_Radio_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            var left = new List<int>(); var right = new List<int>();
            var result = new List<char>();
            var count = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                foreach (var symbol in numbers[i].Split('.'))
                {
                    if (count==0)
                    {
                        var check = int.Parse(symbol);
                        if (check!=0)
                        {
                            left.Add(int.Parse(symbol));                            
                        }
                        count++;
                    }
                    else if (count==1)
                    {
                        var check = int.Parse(symbol);
                        if (check !=0)
                            right.Insert(0,int.Parse(symbol));
                    }
                }                    
                count = 0;
            }
            for (int i = 0; i < left.Count; i++)
            {
                result.Add((char)left[i]);
            }
            for (int i = 0; i < right.Count; i++)
            {
                result.Add((char)right[i]);
            }

            Console.WriteLine(string.Join("",result));

        }
    }
}
