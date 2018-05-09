using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Interfaces
{
    interface ILogger
    {
        void Error(string pm, string errorParsingJson);
        void Info(string pm, string userPeshoSuccessfullyRegistered);
    }
}
