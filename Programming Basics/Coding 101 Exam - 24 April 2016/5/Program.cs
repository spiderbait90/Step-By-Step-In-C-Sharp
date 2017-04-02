using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int dots = n + 1;int dash = 2 * n + 1;
            var heith = 2 * n + 2;
            

            Console.Write(new string('.', dots));
            Console.Write(new string('_', dash));
            Console.WriteLine(new string('.', dots));
            dots--;dash -= 2;
            for (int i = 1; i < n+1; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("//");
                Console.Write(new string('_', dash));
                Console.Write("\\\\");
                Console.WriteLine(new string('.', dots));
                dots--; dash += 2;
            }
            int stopdash = (dash - 5) / 2;
            Console.Write("//");
            Console.Write(new string('_', stopdash));
            Console.Write("STOP!");
            Console.Write(new string('_', stopdash));
            Console.WriteLine("\\\\");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write("\\\\");
                Console.Write(new string('_', dash));
                Console.Write("//");
                Console.WriteLine(new string('.', dots));
                dots++;dash -= 2;
            }

        }
    }
}
