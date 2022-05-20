using System;

namespace fastLPI.tools.decompiler
{
    public interface IJavaDecompilerLogs
    {
        void AddLog(string data, bool showTime = false);
        IEquatable<string> GetLogs();
    }
}
