using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Append_Lists
{
    class Program
    {
        static void Main(string[] args)
        {            
            var result = new List<string>();
            var input = Console.ReadLine().Split('|').ToList();
            
            for (int i = input.Count-1; i >=0; i--)
            {
                var asd = input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int b = 0; b < asd.Length; b++)
                {
                    result.Add(asd[b]);
                }                
            }
            Console.WriteLine(string.Join(" ",result));

            


        }
    }
}
