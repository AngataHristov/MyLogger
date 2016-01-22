
namespace MyLogger.Interfaces
{
    using System;
    using Enums;

    public interface ILayout
    {
        string MakeLayout(DateTime dateTime, ReportLevels reportLevel, string message);
    }
}
