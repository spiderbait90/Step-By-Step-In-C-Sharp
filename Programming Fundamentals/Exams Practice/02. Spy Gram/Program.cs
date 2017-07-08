using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _Spy_Gram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var data = new Dictionary<string, List<string>>();
            var regex = new Regex(@"^TO: ([A-Z]+); MESSAGE: (.+?);$");
            var key = Console.ReadLine();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                    break;
                var match = regex.Match(input);
                if (match.Success)
                {
                    var message = match.Groups[2].Value;
                    var name = match.Groups[1].Value;
                    var whole = match.Value;
                    var decrypted = DecryptMessage(whole, key);
                    if (!data.ContainsKey(name))
                        data[name] = new List<string>();
                    data[name].Add(decrypted);
                }
            }
            foreach (var name in data
                .OrderBy(x => x.Key))
            {
                foreach (var mess in name.Value)
                {
                    Console.WriteLine(mess);
                }
            }
        }

        public static string DecryptMessage(string whole, string key)
        {
            var resultMessage = new StringBuilder();
            var lenght = 0;
            for (int a = 0; a < whole.Length; a++)
            {
                resultMessage.Append((char)(whole[a] + int.Parse(key[lenght].ToString())));
                lenght++;
                if (lenght > key.Length - 1)
                    lenght = 0;
            }
            return resultMessage.ToString();
        }
    }
}