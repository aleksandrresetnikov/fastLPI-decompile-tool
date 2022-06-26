using System;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.diagnostics
{
    [Serializable]
    public class LogsCollector : List<Log>, ILogsCollector, IDisposable
    {
        public void AddLog(string data, bool showTime = false)
        {
            LogBuilder logBuilder = new LogBuilder(data, showTime);
            this.Add(logBuilder.BuildLog());
        }

        public List<string> GetLogs()
        {
            List<string> outputValue = new List<string>();

            foreach (Log item in this)
                outputValue.Add(item.Message);

            return outputValue;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        ~LogsCollector()
        {
            Dispose();
        }
    }
}
