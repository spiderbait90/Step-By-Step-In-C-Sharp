using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var type = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var number = long.MinValue;
            for (int i = 0; i < n; i++)
            {
                var id = long.Parse(Console.ReadLine());

                if (type == "sbyte")
                {
                   if (id<=sbyte.MaxValue&&id>=sbyte.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
                else if (type=="int")
                {
                    if (id <= int.MaxValue && id >= int.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
                else if (type=="long")
                {
                    if (id <= long.MaxValue && id >= long.MinValue)
                    {
                        if (id > number)
                            number = id;
                    }
                }
            }
            Console.WriteLine(number);
            
        }
    }
}
