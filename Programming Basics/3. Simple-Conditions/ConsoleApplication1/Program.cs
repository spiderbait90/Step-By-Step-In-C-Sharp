using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Obem = int.Parse(Console.ReadLine());
            var Pipe1 = int.Parse(Console.ReadLine());
            var Pipe2 = int.Parse(Console.ReadLine());
            var Hours = double.Parse(Console.ReadLine());
            var Pipe11 = Hours * Pipe1;
            var Pipe22 = Hours * Pipe2;
            double Pipes = Pipe11 + Pipe22;
            if (Pipes <= Obem)
            {
                double PipesPerc = Pipes * 100 / Obem;
                Pipe11 = Pipe11 * 100 / Pipes;
                Pipe22 = Pipe22 * 100 / Pipes;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(PipesPerc), Math.Truncate(Pipe11), Math.Truncate(Pipe22));
            }
            else if (Pipes > Obem)
            {
                double result = Pipes - Obem;
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", Hours, result);
            }

        }
    }
}
