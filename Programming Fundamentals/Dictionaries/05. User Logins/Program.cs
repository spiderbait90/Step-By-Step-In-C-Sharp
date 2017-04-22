using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.User_Logins
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var data = new Dictionary<string, string>();

            while (input != "login")
            {
                var name0Pass1 = input.Split(new[] { ' ', '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries);

                data[name0Pass1[0]] = name0Pass1[1];
                input = Console.ReadLine();
            }
            var loginAtemts = 0;
            input = Console.ReadLine();
            while (input != "end")
            {
                var name0Pass1 = input.Split(new[] { ' ', '-', '>' }
                , StringSplitOptions.RemoveEmptyEntries);

                if (data.ContainsKey(name0Pass1[0]))
                {
                    if (data[name0Pass1[0]] == name0Pass1[1])
                    {
                        Console.WriteLine($"{name0Pass1[0]}: logged in successfully");
                    }
                    else if (data[name0Pass1[0]] != name0Pass1[1])
                    {
                        Console.WriteLine($"{name0Pass1[0]}: login failed");
                        loginAtemts++;
                    }
                }
                else
                {
                    Console.WriteLine($"{name0Pass1[0]}: login failed");
                    loginAtemts++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"unsuccessful login attempts: {loginAtemts}");
        }
    }
}
