using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camel_s_Back
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var m = int.Parse(Console.ReadLine());
            var cut = (n.Count - m) / 2;
            var rounds = 0;

            while (cut>0)
            {
                n.RemoveAt(0);
                n.RemoveAt(n.Count-1);
                cut--;
                rounds++;
            }
            if (rounds==0)
            {
                Console.WriteLine($"already stable: {string.Join(" ",n)}");
            }
            else
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", n)}");
            }
        }

    }
}
