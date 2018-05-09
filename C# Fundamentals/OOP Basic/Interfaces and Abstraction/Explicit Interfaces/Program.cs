using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var input = Console.ReadLine().Split(' ');

            if (input[0] == "End")
                break;

            IPerson iPerson = new Citizen(input[0], input[2], input[1]);

            IResident iResident = (IResident)iPerson;

            Console.WriteLine(iPerson.GetName());
            Console.WriteLine(iResident.GetName());

        }
    }
}

