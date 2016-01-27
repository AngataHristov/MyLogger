namespace MyLogger.Layouts
{
    using System;
    using System.Text;
    using Enums;
    using Interfaces;

    public class SimpleLayout : ILayout
    {
        public string MakeLayout(DateTime dateTime, ReportLevels reportLevel, string message)
        {
            string result = string.Format("{0} - {1} - {2}", dateTime, reportLevel, message);

            return result;
        }
    }
}
