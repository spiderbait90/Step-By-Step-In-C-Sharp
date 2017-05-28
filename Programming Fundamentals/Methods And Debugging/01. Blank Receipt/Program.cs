using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            printAll();
        }

        private static void printAll()
        {
            printHead();
            printBody();
            printFooter();
        }

        private static void printFooter()
        {
            Console.WriteLine("------------------------------");            
            Console.WriteLine("© SoftUni");
        }

        private static void printBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        private static void printHead()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
