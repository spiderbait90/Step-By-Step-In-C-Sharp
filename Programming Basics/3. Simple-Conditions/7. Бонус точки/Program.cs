using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Бонус_точки
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            double Bonus;
            
            double result = 0;
            if (num <= 100)       
                Bonus = 5;                           
            else if (num > 100 && num <= 1000)            
                Bonus = num * 0.20;
            else            
                Bonus = num * 0.10;            
            if (num % 2 == 0)           
                Bonus = Bonus + 1;            
            else if (num % 5 == 0)            
                Bonus = Bonus + 2;            
            Console.WriteLine(Bonus);
            result = Bonus + num ;
            Console.WriteLine(result);
                
        }
    }
}
