using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Char_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = Console.ReadLine().ToArray();
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string resultFinal = "";
            
            for (int i = 0; i <code.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    int result = Math.Abs(code[i]-numbers[i]);
                    resultFinal += Convert.ToChar(result);
                }
                else if (numbers[i]%2!=0)
                {
                    int result = numbers[i] + code[i];
                    resultFinal+= Convert.ToChar(result);
                    
                }
            }
            Console.WriteLine(resultFinal);
                
        }
    }
}
