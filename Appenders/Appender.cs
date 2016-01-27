namespace MyLogger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        private ILayout layout;
        private const ReportLevels DefaultLevel = ReportLevels.Info;

        protected Appender(ILayout layout, ReportLevels reportLevel = DefaultLevel)
        {
            this.Layout = layout;
            this.ReportLevel = reportLevel;
        }

        public ReportLevels ReportLevel { get; set; }

        public ILayout Layout
        {
            get { return this.layout; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Layout cannot be null!");
                }

                this.layout = value;
            }
        }

        public abstract void Append(DateTime dateTime, ReportLevels reportLevel, string message);

        protected bool CheckReportLevel(ReportLevels reportLevel)
        {
            return (int)reportLevel >= (int)this.ReportLevel;
        }
    }
}
