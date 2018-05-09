using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        try
        {
            var firstInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var secondInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var student = new Student(firstInput[0], firstInput[1], firstInput[2]);

            var worker = new Worker(secondInput[0], secondInput[1], decimal.Parse(secondInput[2]), decimal.Parse(secondInput[3]));

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        
    }
}

