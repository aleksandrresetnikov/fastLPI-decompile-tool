namespace fastLPI.tools.decompiler.diagnostics
{
    public interface ILogsCollector
    {
        void AddLog(string data, bool showTime = false);
        System.Collections.Generic.List<string> GetLogs();
    }
}
