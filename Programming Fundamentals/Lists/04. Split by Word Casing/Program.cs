using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']', '\'', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();         
                       
            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();
            bool checkLower = false;
            bool checkUpper = false;
            for (int a = 0; a < text.Count; a++)
            {
                var leters = text[a].ToCharArray();
                for (int b = 0; b < leters.Length; b++)
                {
                    if (leters[b]>='a'&& leters[b] <= 'z')
                    {
                        checkLower = true;
                    }
                    else if (leters[b] >= 'A' && leters[b] <= 'Z')
                    {
                        checkUpper = true;
                    }
                    else
                    {
                        checkLower = true; checkUpper = true;
                    }
                }
                if (checkLower == true && checkUpper == true)
                    mixedCase.Add(text[a]);
                else if (checkLower == true)
                    lowerCase.Add(text[a]);
                else if (checkUpper == true)
                    upperCase.Add(text[a]);
                else
                    mixedCase.Add(text[a]);
                checkLower = false;
                checkUpper = false;
            }
            Console.WriteLine("Lower-case: "+string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));


        }
    }
}
