﻿
namespace MyLogger
{
    using System;
    using Enums;
    using Interfaces;

    public class Logger : ILogger
    {
        private IAppender appender;

        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }

        public IAppender Appender
        {
            get
            {
                return this.appender;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Appender cannot be null!");
                }

                this.appender = value;
            }
        }

        public void Info(string message)
        {
            this.Log(ReportLevels.Info, message);
        }

        public void Warn(string message)
        {
            this.Log(ReportLevels.Warn, message);
        }

        public void Error(string message)
        {
            this.Log(ReportLevels.Error, message);
        }

        public void Critical(string message)
        {
            this.Log(ReportLevels.Critical, message);
        }

        public void Fatal(string message)
        {
            this.Log(ReportLevels.Fatal, message);
        }

        private void Log(ReportLevels reportLevels, string message)
        {
            DateTime dateTime = DateTime.Now;

            this.Appender.Append(dateTime, reportLevels, message);
        }
    }
}