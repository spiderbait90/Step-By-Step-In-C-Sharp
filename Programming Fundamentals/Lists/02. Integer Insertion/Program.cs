using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Integer_Insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            var intNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var strNumbers = new List<string>();
            var input = Console.ReadLine();            

             while (input != "end")
            {
                var firstDigit = (int)char.GetNumericValue(input[0]);
                var allDigits = int.Parse(input);
                intNumbers.Insert(firstDigit, allDigits);
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ",intNumbers));

        }
    }
}
