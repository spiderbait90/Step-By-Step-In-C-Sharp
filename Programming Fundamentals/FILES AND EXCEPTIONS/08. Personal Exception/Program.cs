using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Personal_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    var n = int.Parse(Console.ReadLine());
                    if (n < 0)
                    {
                        throw new PersonalException();
                    }
                    Console.WriteLine(n);
                }
            }
            catch (PersonalException myEx)
            {
                Console.WriteLine(myEx.Message);                
            }
            
        }
    }
}
