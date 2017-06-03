using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var boolean = Console.ReadLine();
            Convert.ToBoolean(boolean);
            if (boolean=="True")
                Console.WriteLine("Yes");
            else 
                Console.WriteLine("No");
        }
    }
}
