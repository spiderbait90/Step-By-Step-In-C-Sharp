using System;
using Logger.Interfaces;
using Logger.Models;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //var n = int.Parse(Console.ReadLine());

            //for (int i = 0; i < n; i++)
            //{
            //    var input = Console.ReadLine()
            //        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    var appenderType = input[0];
            //    var layOutType = input[1];
            //    var reportLevel = string.Empty;

            //    if (input.Length == 3)
            //        reportLevel = input[2];
            //}

            //while (true)
            //{
            //    var input = Console.ReadLine()
            //        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    if (input[0] == "END")
            //        break;
            //}

            var simpleLayout = new SimpleLayout();
            var consoleAppender = new ConsoleAppender(simpleLayout);
            consoleAppender.ReportLevel = ReportLevel.Error;

            var logger = new Logger(consoleAppender);

            logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
            logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
            logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
            logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
            logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");


        }
    }
}
