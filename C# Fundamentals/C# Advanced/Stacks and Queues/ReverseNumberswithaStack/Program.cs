using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumberswithaStack
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Stack<long> nums = new Stack<long>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray());

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
