using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Намиране_на_по_голямото_число
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine(n1);
            else
                Console.WriteLine(n2);
        }
    }
}
