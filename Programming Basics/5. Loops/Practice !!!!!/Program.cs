using System;
namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0; var p2 = 0.0; var p3 = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
            }
            var p11 = p1 / n * 100;
            var p22 = p2 / n * 100;
            var p33 = p3 / n * 100;
            Console.WriteLine($"{p11:f2}%");
            Console.WriteLine($"{p22:f2}%");
            Console.WriteLine($"{p33:f2}%");


        }
    }
}