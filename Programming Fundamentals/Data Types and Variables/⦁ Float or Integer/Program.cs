using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Float_or_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal a = 9450000000000m * 4.22m;
            Decimal b = 9450000000000m * 26000m;
            Decimal c = 9450000000000m * 100000m;
            Decimal d = 9450000000000m * 46500000000m;

            Console.WriteLine(a.ToString("e2"));
            Console.WriteLine(b.ToString("e2"));
            Console.WriteLine(c.ToString("e2"));
            Console.WriteLine(d.ToString("e2"));

        }
    }
}
