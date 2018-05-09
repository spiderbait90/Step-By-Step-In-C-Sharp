using Logger.Interfaces;

namespace Logger
{
    internal class ConsoleAppender : IAppender
    {
        private ILayout simpleLayout;
        private XmlLayout xmlLayout;

        public ConsoleAppender(ILayout simpleLayout)
        {
            this.simpleLayout = simpleLayout;
        }

        public ConsoleAppender(XmlLayout xmlLayout)
        {
            this.xmlLayout = xmlLayout;
        }

        public object ReportLevel { get; internal set; }
    }
}