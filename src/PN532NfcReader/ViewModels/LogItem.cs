using System;

namespace PN532NfcReader.ViewModels
{
    public class LogItem
    {
        public string Timestamp { get; set; }
        public string Content { get; set; }
        public bool IsReceived { get; set; }
    }
}
