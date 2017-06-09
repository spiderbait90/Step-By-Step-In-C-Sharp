using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, 
                Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                    break;

                var splited = input.Split(new[] { '=', ' ' });
                var ip = splited[1];
                var user = splited[5];

                if (!data.ContainsKey(user))
                {
                    data[user] = new Dictionary<string, int>();                    
                }
                if (!data[user].ContainsKey(ip))
                {
                    data[user][ip] = 1;
                }
                else
                    data[user][ip]++;
            }
            var count = 0;
            foreach (var user in data.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{user.Key}:");
                foreach (var ip in user.Value)
                {
                    count++;
                    Console.Write($"{ip.Key} => {ip.Value}");
                    if (count<user.Value.Count)
                    Console.Write(", ");
                }
                Console.WriteLine(".");
                count = 0;
            }

        }
    }
}
