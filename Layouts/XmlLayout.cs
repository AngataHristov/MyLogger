namespace MyLogger.Layouts
{
    using System;
    using System.Text;
    using Enums;
    using Interfaces;

    public class XmlLayout : ILayout
    {
        public string MakeLayout(DateTime dateTime, ReportLevels reportLevel, string message)
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("<log>");
            result.AppendLine(string.Format("   <date>{0}</date>", dateTime));
            result.AppendLine(string.Format("   <level>{0}</level>", reportLevel));
            result.AppendLine(string.Format("   <message>{0}</message>", message));
            result.AppendLine("</log>");

            return result.ToString();
        }
    }
}
