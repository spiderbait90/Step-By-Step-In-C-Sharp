using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Изписване_на_число_до_10_с_думи
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("Zero");
            else if (n == 1)
                Console.WriteLine("One");
            else if (n == 2)
                Console.WriteLine("Two");
            else if (n == 3)
                Console.WriteLine("Three");
            else if (n == 4)
                Console.WriteLine("Four");
            else if (n == 5)
                Console.WriteLine("Five");
            else if (n == 6)
                Console.WriteLine("Six");
            else if (n == 7)
                Console.WriteLine("Seven");
            else if (n == 8)
                Console.WriteLine("Eight");
            else if (n == 9)
                Console.WriteLine("Nine");
            else 
                Console.WriteLine("number too big");

        }
    }
}
