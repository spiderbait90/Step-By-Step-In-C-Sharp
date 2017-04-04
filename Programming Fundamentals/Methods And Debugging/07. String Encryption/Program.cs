using System;


namespace _07.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                result += Enctypt(letter);
                
            }
            Console.WriteLine(result);
        }
        static string Enctypt(char letter)
        {
            string result = string.Empty;
            var ascii = (int)letter;
            var last = ascii % 10;
            var first = ascii;
            while(first>=10)
            {
                first /= 10; ;
            }            
            string digitMid = first.ToString() + last.ToString();
            var begin = (char)(ascii + last);
            var end = (char)(ascii - first);
            result = begin + digitMid + end;
            return result;
            

        }
    }
}
