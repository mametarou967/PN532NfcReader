namespace PN532NfcReader.Model.Logging
{
    public interface ILogWriteRequester
    {
        void WriteRequest(string message);
    }
}
