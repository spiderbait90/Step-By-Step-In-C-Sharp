using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine().ToArray()
                .Select(x => x.ToString()).Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine();
            var data = new Dictionary<string, List<string>>();
            var pattern = new Regex(@"^TO: ([A-Z]+); MESSAGE: (.+);$");

            while (input != "END")
            {
                var match = pattern.Match(input);

                if (match.Length == 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                var message = match.ToString().ToCharArray()
                    .Select(x => Convert.ToInt32(x)).ToArray();
                var name = match.Groups[1].ToString();
                int count = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    for (int b = count; b <= key.Length; b++)
                    {
                        if (b <= key.Length - 1)
                        {
                            message[i] += key[b];
                            count++;
                            break;
                        }
                        else
                        {
                            count = 0;
                            i--;
                        }
                    }
                }
                var newmessage = message.Select(x => Convert.ToChar(x)).ToArray();

                if (!data.ContainsKey(name))
                    data[name] = new List<string>();
                data[name].Add(string.Join("", newmessage));

                input = Console.ReadLine();
            }

            foreach (var name in data.OrderBy(x => x.Key))
            {
                foreach (var mess in name.Value)
                {
                    Console.WriteLine(mess);
                }
            }
        }
    }
}
