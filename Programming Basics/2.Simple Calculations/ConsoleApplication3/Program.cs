using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var FirstName = Console.ReadLine();
            
            var LastName = Console.ReadLine();
           
            var age = (Console.ReadLine());
           
            var town = Console.ReadLine();
            Console.WriteLine($"You are {FirstName} {LastName}, a {age}-years old person from {town}.",FirstName,LastName,age,town);
        }
    }
}
