namespace MyLogger
{
    using System;
    using Appenders;
    using Enums;
    using Interfaces;
    using Layouts;

    public class MyLoggerMain
    {
        public static void Main()
        {
            try
            {
                ILayout simpleLayout = new SimpleLayout();
                ILayout xmlLayout = new XmlLayout();
                ILayout jsonLayout = new JsonLayout();

                ConsoleAppender consoleAppender = new ConsoleAppender(simpleLayout);
                FileAppender fileAppender = new FileAppender(simpleLayout);

                ILogger logger = new Logger(consoleAppender);

                logger.Info("Everything seems fine");
                logger.Warn("Warning: ping is too high - disconnect imminent");
                logger.Error("Error parsing request");
                logger.Critical("No connection string found in App.config");
                logger.Fatal("mscorlib.dll does not respond");

                Console.WriteLine(new string('-', 50));

                consoleAppender.Layout = xmlLayout;

                logger.Info("Everything seems fine");
                logger.Warn("Warning: ping is too high - disconnect imminent");
                logger.Error("Error parsing request");
                logger.Critical("No connection string found in App.config");
                logger.Fatal("mscorlib.dll does not respond");

                Console.WriteLine(new string('-', 50));

                consoleAppender.Layout = jsonLayout;

                logger.Info("Everything seems fine");
                logger.Warn("Warning: ping is too high - disconnect imminent");
                logger.Error("Error parsing request");
                logger.Critical("No connection string found in App.config");
                logger.Fatal("mscorlib.dll does not respond");

                Console.WriteLine(new string('-', 50));

                try
                {
                    logger.Appender = fileAppender;

                    logger.Info("Everything seems fine");
                    logger.Warn("Warning: ping is too high - disconnect imminent");
                    logger.Error("Error parsing request");
                    logger.Critical("No connection string found in App.config");
                    logger.Fatal("mscorlib.dll does not respond");

                    fileAppender.Layout = xmlLayout;

                    logger.Info("Everything seems fine");
                    logger.Warn("Warning: ping is too high - disconnect imminent");
                    logger.Error("Error parsing request");
                    logger.Critical("No connection string found in App.config");
                    logger.Fatal("mscorlib.dll does not respond");

                    fileAppender.Layout = jsonLayout;

                    logger.Info("Everything seems fine");
                    logger.Warn("Warning: ping is too high - disconnect imminent");
                    logger.Error("Error parsing request");
                    logger.Critical("No connection string found in App.config");
                    logger.Fatal("mscorlib.dll does not respond");
                }
                finally
                {
                    fileAppender.Close();
                }
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }

            try
            {
                //Report Threshold testing
                var simpleLayout = new SimpleLayout();
                var consoleAppender = new ConsoleAppender(simpleLayout);

                consoleAppender.ReportLevel = ReportLevels.Error;

                var logger = new Logger(consoleAppender);

                logger.Info("Everything seems fine");
                logger.Warn("Warning: ping is too high - disconnect imminent");
                logger.Error("Error parsing request");
                logger.Critical("No connection string found in App.config");
                logger.Fatal("mscorlib.dll does not respond");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
        }
    }
}
