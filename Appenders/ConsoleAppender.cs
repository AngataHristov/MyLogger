
namespace MyLogger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(DateTime dateTime, ReportLevels reportLevel, string message)
        {
            string result = this.Layout.MakeLayout(dateTime, reportLevel, message);

            if (base.CheckReportLevel(reportLevel))
            {
                Console.WriteLine(result);
            }
        }
    }
}
