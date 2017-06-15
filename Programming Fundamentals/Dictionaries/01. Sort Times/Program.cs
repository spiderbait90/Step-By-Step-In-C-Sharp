using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var times = Console.ReadLine()
                .Split()
                .Select(x => DateTime.Parse(x))
                .Select(x => x.ToString(@"HH:mm"))
                .OrderBy(x=>x)
                .ToList();

            Console.WriteLine(string.Join(", ",times));
        }
    }
}
