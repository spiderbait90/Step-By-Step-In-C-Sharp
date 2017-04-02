using System;

namespace _1.Declaring_and_Invoking_Methods
{
    class Program
    {
        static void Main()
        {
            Total();
        }
        static void Total()
        {
            Top();Mid();Bot();
        }
        static void Top()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void Mid()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void Bot()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9 SoftUni");
        }





    }
}
