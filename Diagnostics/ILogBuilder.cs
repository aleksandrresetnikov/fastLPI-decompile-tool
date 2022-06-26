namespace fastLPI.tools.decompiler.diagnostics
{
    public interface ILogBuilder
    {
        Log BuildLog();
        void SetData(string Data);
        void SetShowTime(bool ShowTime);
    }
}
