using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            bool check = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                    check = true;
            }
            if (check == true)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
