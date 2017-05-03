using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Word_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine().ToCharArray();
            var text = Console.ReadLine();

            var letter = filter[0];
            var digit = int.Parse(filter[1].ToString());
            var wordExtract = @"\w+";
            var validText = @"^[A-Z].*[.!?]$";
            var list = new List<string>();
            while (text!="end")
            {
                if (Regex.Match(text, validText).Length>0)
                {
                    var words = Regex.Matches(text, wordExtract);

                    foreach (Match word in words)
                    {
                        var count = 0;
                        foreach (var charr in word.Value)
                        {
                            if (charr == letter)
                            {
                                count++;                                
                            }
                        }
                        if (count >= digit)
                            list.Add(word.Value);
                    }
                }
                text = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",list));
        }
    }
}
