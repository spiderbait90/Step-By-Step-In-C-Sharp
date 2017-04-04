using System;

namespace _03.String_Repeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(StringCount(a,b));
        }
        static string StringCount(string str,int count)
        {
            string strCombine = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                strCombine += str;
            }
            return strCombine;
        }
        
    }
}
