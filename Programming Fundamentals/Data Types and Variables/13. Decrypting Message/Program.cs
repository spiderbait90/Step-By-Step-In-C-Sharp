using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = sbyte.Parse(Console.ReadLine());
            var n = sbyte.Parse(Console.ReadLine());
            var message = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                letter += (char)key;
                message += letter;
            }
            Console.WriteLine(message);
        }
    }
}
