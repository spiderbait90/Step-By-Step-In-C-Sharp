using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sort_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var strings = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < strings.Length-1; i++)
            {
                if (strings[i].CompareTo(strings[i + 1])==1)
                {
                    var temp = strings[i];
                    strings[i] = strings[i + 1];
                    strings[i + 1] = temp;
                    i = -1;
                }               
            }
            Console.WriteLine(string.Join(" ",strings));
        }
    }
}
