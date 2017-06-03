using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Number_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var check = false;
            foreach (var item in input)
            {
                if (item=='.')
                {
                    Console.WriteLine("floating-point");
                    check = true;
                    return;
                }
            }
            if (!check)
                Console.WriteLine("integer");
        }
    }
}
