using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _Hornet_Comm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var messageReg = new Regex(@"(^\d+) <-> ([\da-zA-Z]+$)");
            var broadCastReg = new Regex(@"(^[^\d]+) <-> ([\da-zA-Z]+$)");
            var messages = new List<string>();
            var broadCasts = new List<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "Hornet is Green")
                    break;

                var matchMessage = messageReg.Match(line);
                var matchBroadCast = broadCastReg.Match(line);

                if (matchMessage.Success)
                {
                    var reversed =
                        new string(matchMessage.Groups[1].Value.Reverse().ToArray());
                    messages.Add($"{reversed} -> {matchMessage.Groups[2].Value}");
                }
                else if (matchBroadCast.Success)
                {
                    var newFreq = new StringBuilder();
                    foreach (var letter in matchBroadCast.Groups[2].Value)
                    {
                        if (char.IsLower(letter))
                            newFreq.Append(letter.ToString().ToUpper());
                        else if (char.IsUpper(letter))
                            newFreq.Append(letter.ToString().ToLower());
                        else
                            newFreq.Append(letter);

                    }
                    broadCasts.Add($"{newFreq.ToString()} -> {matchBroadCast.Groups[1].Value}");
                }
            }
            if (broadCasts.Count == 0)
                broadCasts.Add("None");
            if (messages.Count == 0)
                messages.Add("None");

            Console.WriteLine("Broadcasts:");
            foreach (var broad in broadCasts)
            {
                Console.WriteLine(broad);
            }
            Console.WriteLine("Messages:");
            foreach (var mess in messages)
            {
                Console.WriteLine(mess);
            }
        }
    }
}