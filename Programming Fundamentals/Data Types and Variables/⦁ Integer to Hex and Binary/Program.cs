using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());            
            Console.WriteLine(num.ToString("X"));
            Console.WriteLine(Convert.ToString(num,2));

        }
    }
}
