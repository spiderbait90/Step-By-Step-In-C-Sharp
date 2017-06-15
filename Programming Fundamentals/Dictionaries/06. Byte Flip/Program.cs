using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Reverse()
                .ToList();

            foreach (var item in input)
            {
                var hex = new string(item.Reverse().ToArray());
                Console.Write((char)Convert.ToInt32(hex,16));
            }
            Console.WriteLine();
        }
    }
}
