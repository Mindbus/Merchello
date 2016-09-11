namespace Merchello.Core.Acquired.Logging
{
    using System;

    using log4net.Core;

    /// <remarks>
    /// Borrowed from https://github.com/cjbhaines/Log4Net.Async - will reference Nuget packages directly in v8 REFACTOR remove when V8 Released
    /// </remarks>
    /// UMBRACO
    internal sealed class LoggingEventHelper
    {
        // needs to be a seperate class so that location is determined correctly by log4net when required

        private static readonly Type HelperType = typeof(LoggingEventHelper);
        private readonly string loggerName;

        public FixFlags Fix { get; set; }

        public LoggingEventHelper(string loggerName, FixFlags fix)
        {
            this.loggerName = loggerName;
            this.Fix = fix;
        }

        public LoggingEvent CreateLoggingEvent(Level level, string message, Exception exception)
        {
            var loggingEvent = new LoggingEvent(HelperType, null, this.loggerName, level, message, exception)
            {
                Fix = this.Fix
            };
            return loggingEvent;
        }
    }
}