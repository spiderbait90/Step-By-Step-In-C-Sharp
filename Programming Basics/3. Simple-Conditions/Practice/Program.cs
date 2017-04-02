using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            var password = Console.ReadLine();
            string correctPass = "s3cr3t!P@ssw0rd";
            if (correctPass == password)
            {
                Console.WriteLine("Welcome");
            }
            else if (password != correctPass)
            {
            Console.WriteLine("Wrong password!");
             }
                
       
        }
    }
}
