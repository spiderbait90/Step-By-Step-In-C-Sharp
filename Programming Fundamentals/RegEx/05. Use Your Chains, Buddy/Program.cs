using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Use_Your_Chains__Buddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = new Regex(@"<p>(.+?)<\/p>");         
            var matches = pattern.Matches(text);
            var result = "";

            foreach (Match item in matches)
            {
                var txt =
                    Regex.Replace
                    (item.Groups[1].Value, @"([^a-z0-9])", " ");
                txt = Regex.Replace(txt, @"\s+", " ");

                result += Decrypt(txt);            
            }
            Console.WriteLine(result);
        }

        public static string Decrypt(string txt)
        {
            var str = "";
            foreach (var letter in txt)
            {
                if (char.IsLetter(letter))
                {
                    if (letter < 'n')
                    {
                        str += (char)(letter + 13);
                    }
                    else
                        str += (char)(letter - 13);
                }
                else if (letter == ' ')
                    str += " ";
                else if (char.IsDigit(letter))
                    str += letter;
            }
            return str;
        }
    }
}
