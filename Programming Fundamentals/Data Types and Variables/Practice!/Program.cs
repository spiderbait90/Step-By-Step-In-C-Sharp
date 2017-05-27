namespace Practice_
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string cypher = ""; var previousStr = "";

            for (int i = 1; i <= n; i++)
            {

                var str = Console.ReadLine();

                if (str != "spin")
                {
                    cypher += str;
                    if (previousStr == str) cypher = "";
                    previousStr = str;                   

                }
                else if (str == "spin")
                {
                    if (str == "spin" && previousStr == "spin") cypher = "";
                    previousStr = str;
                    for (int a = 1; a <= n; i++)
                    {
                        
                        str = Console.ReadLine();
                        if (str == "spin" && previousStr == str) cypher = "";
                        if (str == "spin")
                        {
                            i--;   previousStr = str; break;
                        }

                        cypher = str + cypher;
                        if (previousStr == str) cypher = "";
                        previousStr = str;
                        
                        if (i >= n)
                        {
                            Console.WriteLine(cypher);
                            return;
                        }
                    }


                }
            }
            Console.WriteLine(cypher);
        }
    }
}
