using Prism.Events;
using System;

namespace PN532NfcReader.Model.Logging
{
    public enum LogType
    {
        DataReceive,
        DataSend,
        System
    }

    public class Log
    {
        public string content;
        public DateTime dateTime;
        public LogType logType;
    }

    public class LogEvent : PubSubEvent<Log> { }
}
