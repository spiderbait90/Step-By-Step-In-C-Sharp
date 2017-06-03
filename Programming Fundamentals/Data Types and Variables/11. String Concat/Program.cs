using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimeter = char.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var str = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                var word = Console.ReadLine();
                if (type == "even")
                {
                    if (i % 2 == 0)
                        str += delimeter + word;
                }
                else if (type=="odd")
                {
                    if (i % 2 != 0)
                        str += delimeter + word;
                }
            }
            str = str.Remove(0,1);
            Console.WriteLine(str);

        }
    }
}
