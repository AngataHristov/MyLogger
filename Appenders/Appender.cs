

namespace MyLogger.Appenders
{
    using System;
    using Enums;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        private ILayout layout;

        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevels.Info;
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
    }
}
