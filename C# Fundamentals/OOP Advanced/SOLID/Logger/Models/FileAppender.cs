using System;
using System.Collections.Generic;
using System.Text;
using Logger.Interfaces;

namespace Logger.Models
{
    class FileAppender:IAppender
    {
        private ILayout simpleLayout;

        public FileAppender(ILayout simpleLayout)
        {
            this.simpleLayout = simpleLayout;
        }

        public LogFile File { get; set; }
    }
}
