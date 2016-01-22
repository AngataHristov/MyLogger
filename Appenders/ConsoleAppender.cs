
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

            this.CheckReportLevel(reportLevel, result);
        }

        private void CheckReportLevel(ReportLevels reportLevel, string result)
        {
            if ((int)reportLevel >= (int)this.ReportLevel)
            {
                Console.WriteLine(result);
            }
        }
    }
}
