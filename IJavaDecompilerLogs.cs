﻿namespace fastLPI.tools.decompiler
{
    public interface IJavaDecompilerLogs
    {
        void AddLog(string data, bool showTime = false);
        System.Collections.Generic.List<string> GetLogs();
    }
}
