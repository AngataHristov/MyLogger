
namespace MyLogger.Appenders
{
    using System;
    using System.IO;
    using System.Net.Configuration;
    using Enums;
    using Interfaces;

    public class FileAppender : Appender
    {
        private const string DefaultFilePath = "..//log.txt";

        private StreamWriter fileWriter;

        public FileAppender(ILayout layout, string filePath = DefaultFilePath)
            : base(layout)
        {
            this.FilePath = filePath;
            this.fileWriter = new StreamWriter(this.FilePath, true);
        }

        public string FilePath { get; private set; }

        public override void Append(DateTime dateTime, ReportLevels reportLevel, string message)
        {
            string result = this.Layout.MakeLayout(dateTime, reportLevel, message);

            if (this.CheckReportLevel(reportLevel))
            {
                this.fileWriter.WriteLine(result);
            }
        }

        public void Close()
        {
            this.fileWriter.Close();
        }
    }
}
