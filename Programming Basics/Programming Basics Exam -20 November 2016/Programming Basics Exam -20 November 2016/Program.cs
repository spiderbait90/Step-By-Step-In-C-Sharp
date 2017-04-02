using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Basics_Exam__20_November_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 2 * n + 3;
            var stars = 1;var tire = (2 * n + 3) -(2* stars) - 2;
            var midstars = n / 2;
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*',stars));
                Console.Write('\\');
                Console.Write(new string('-',tire));
                Console.Write('/');
                Console.WriteLine(new string('*', stars));
                if (i<n)stars++;
                if(i<n)tire -= 2;
                
            }

            for (int i = 1; i <= n/3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*',midstars));
                Console.Write('\\');
                Console.Write(new string('*',stars));
                Console.Write('/');
                Console.Write(new string('*', midstars));
                Console.WriteLine('|');
                if(i<n/3)midstars++;
                if (i<n/3)stars -= 2;
            }
            stars = stars + (2 * midstars);
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', tire));
                Console.Write('\\');
                Console.Write(new string('*',stars));
                Console.Write('/');
                Console.WriteLine(new string('-', tire));
                tire++;
                stars -= 2;
            }
        }
    }
}
