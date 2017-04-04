using System;

namespace _04.Numbers_inReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            
            Console.WriteLine(Revers(n.ToString()));
        }
        static string Revers(string n)
        {
            string result = string.Empty;

            foreach (var item in n)
            {
                result = item + result ;
            }
            return result;
        }
        
    }
}
