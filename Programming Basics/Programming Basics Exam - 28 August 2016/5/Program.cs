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
            var wide = 5 * n; 
            var midtire = 0; var dqsnotire = wide - (3 * n)-2;
            var tire = wide - (dqsnotire + 2);
            for (int top = 1; top <= n; top++)
            {
                Console.Write(new string('-', tire));
                Console.Write('*');
                Console.Write(new string('-', midtire));
                Console.Write('*');
                Console.WriteLine(new string('-', dqsnotire));
                if (top < n)
                {
                    midtire++; dqsnotire--;
                }
            }
            for (int mid = 1; mid <= n/2; mid++)
            {
                Console.Write(new string('*',tire+1));
                Console.Write(new string('-',midtire));
                Console.Write('*');
                Console.WriteLine(new string('-', dqsnotire));
            }
            for (int bot = 1; bot <=n/2-1; bot++)
            {
                Console.Write(new string('-', tire));
                Console.Write('*');
                Console.Write(new string('-', midtire));
                Console.Write('*');
                Console.WriteLine(new string('-', dqsnotire));
                midtire += 2;tire--;dqsnotire--;
            }
            Console.Write(new string('-',tire));
            Console.Write(new string('*',midtire+2));
            Console.WriteLine(new string('-',dqsnotire));

        }
    }
}
