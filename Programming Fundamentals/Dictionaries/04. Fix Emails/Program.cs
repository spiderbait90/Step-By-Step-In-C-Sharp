using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                    break;
                var email = Console.ReadLine();

                if (email.EndsWith("us") ||
                    email.EndsWith("uk"))
                {
                    continue;
                }
                else
                    data[name] = email;
            }

            foreach (var item in data)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
