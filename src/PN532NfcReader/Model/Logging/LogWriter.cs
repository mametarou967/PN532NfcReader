using Prism.Events;
using System;

namespace PN532NfcReader.Model.Logging
{
    class LogWriter
    {
        IEventAggregator _ea;
        Action<Log> logWrite;

        public LogWriter(IEventAggregator ea, Action<Log> logWrite)// Collection<LogItem> logItems)
        {
            _ea = ea;
            this.logWrite = logWrite;

            _ea.GetEvent<LogEvent>().Subscribe(Write);
        }

        public void Write(Log log)
        {
            logWrite(log);
            _ea.GetEvent<LogUpdated>().Publish(true);
        }
    }
}
