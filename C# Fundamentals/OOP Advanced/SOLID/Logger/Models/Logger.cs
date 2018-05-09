using System;
using System.Collections.Generic;
using System.Text;
using Logger.Interfaces;

namespace Logger
{
    class Logger : ILogger
    {
        private IAppender consoleAppender;
        private IAppender fileAppender;

        public Logger(ConsoleAppender consoleAppender)
        {
            this.consoleAppender = consoleAppender;
        }

        public Logger(IAppender consoleAppender, IAppender fileAppender)
        {
            this.consoleAppender = consoleAppender;
            this.fileAppender = fileAppender;
        }

        public void Error(string pm, string errorParsingJson)
        {
            Console.WriteLine($"{pm} - Error - {errorParsingJson}");
        }

        public void Info(string pm, string userPeshoSuccessfullyRegistered)
        {
            Console.WriteLine($"{pm} - Info - {userPeshoSuccessfullyRegistered}");
        }

        internal void Fatal(string v1, string v2)
        {
            Console.WriteLine();
        }

        internal void Critical(string v1, string v2)
        {
            Console.WriteLine();
        }

        internal void Warn(string v1, string v2)
        {
            Console.WriteLine();
        }
    }
}
