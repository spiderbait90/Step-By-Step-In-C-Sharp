using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMS_Typing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            var message = "";
            for (int i = 0; i < n; i++)
            {
                var number = Console.ReadLine();
                var count = 0;
                var digit = 0;
                foreach (var digitt in number)
                {
                    count++;
                    digit = int.Parse(digitt.ToString());
                }

                switch (digit)
                {
                    case 2: message += alphabet[count - 1]; break;
                    case 3: message += alphabet[count - 1 + 3]; break;
                    case 4: message += alphabet[count - 1 + 6]; break;
                    case 5: message += alphabet[count - 1 + 9]; break;
                    case 6: message += alphabet[count - 1 + 12]; break;
                    case 7: message += alphabet[count - 1 + 15]; break;
                    case 8: message += alphabet[count - 1 + 19]; break;
                    case 9: message += alphabet[count - 1 + 22]; break;
                    case 0: message += " "; break;
                }
            }
            Console.WriteLine(message);
        }
    }
}
