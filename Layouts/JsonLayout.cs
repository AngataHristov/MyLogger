
namespace MyLogger.Layouts
{
    using System;
    using Enums;
    using Interfaces;

    public class JsonLayout : ILayout
    {
        public string MakeLayout(DateTime dateTime, ReportLevels reportLevel, string message)
        {
            string result = string.Format("{{date: {0}; report level: {1}; message: {2}}}", dateTime, reportLevel, message);

            return result;
        }
    }
}
