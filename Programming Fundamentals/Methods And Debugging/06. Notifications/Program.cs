using System;
namespace _06.Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (input=="success")
                {
                    var operation = Console.ReadLine();
                    var message = Console.ReadLine();
                    Console.WriteLine(ShowSuccess(operation,message));
                }
                else if (input =="error")
                {
                    var operation = Console.ReadLine();
                    var code = int.Parse(Console.ReadLine());
                    Console.WriteLine(ShowError(operation,code));

                }

            }
        }
        static string ShowSuccess(string operation, string message)
        {
            string returnInfo = $"Successfully executed {operation}.\n" +
                $"==============================\n" +
                $"Message: {message}.";
            return returnInfo;
        }
        static string ShowError(string operation, int code)
        {
            string a = $"Error: Failed to execute {operation}.\n" +
                $"==============================\n" +
                $"Error Code: {code}.\n";
            if (code>0)
            {
                a += "Reason: Invalid Client Data.";
            }
            else if (code<0)
            {
                a += "Reason: Internal System Failure.";
            }
            return a;
            
        }
    }
}
