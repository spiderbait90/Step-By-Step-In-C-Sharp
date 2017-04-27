using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            
            var rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                var i2 = rnd.Next(input.Length);
                var temp = input[i];
                input[i] = input[i2];
                input[i2] = temp;
            }
                        
            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
