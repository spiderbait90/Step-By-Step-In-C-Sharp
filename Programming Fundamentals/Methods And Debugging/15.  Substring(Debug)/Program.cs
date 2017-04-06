using System;

namespace _Substring_Debug
{
    internal class Program
    {
        private static void Main()
        {
            var text = Console.ReadLine();
            var jump = int.Parse(Console.ReadLine());


            var hasMatch = false;

            for (var i = 0; i < text.Length; i++)
                if (text[i] == 'p')
                {
                    hasMatch = true;

                    var endIndex = jump + 1;

                    if (endIndex + i > text.Length)
                        endIndex = text.Length - i;

                    var matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }

            if (!hasMatch)
                Console.WriteLine("no");
        }
    }
}