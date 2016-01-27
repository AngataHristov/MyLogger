namespace MyLogger.Interfaces
{
    using System;
    using Enums;

    public interface IAppender
    {
        ILayout Layout { get; set; }

        ReportLevels ReportLevel { get; set; }

        void Append(DateTime dateTime, ReportLevels reportLevel, string message);
    }
}
