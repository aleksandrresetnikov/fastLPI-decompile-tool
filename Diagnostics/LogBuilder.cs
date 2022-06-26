using System;

namespace fastLPI.tools.decompiler.diagnostics
{
    public class LogBuilder : IDisposable, ILogBuilder
    {
        public string Data
        { get; private protected set; }

        public bool ShowTime
        { get; private protected set; }

        public LogBuilder(string Data, bool ShowTime = false)
        {
            this.Data = Data;
            this.ShowTime = ShowTime;
        }

        public Log BuildLog()
        {
            string dateTime = DateTime.Now.ToString();

            return new Log
            {
                DateTime = dateTime,
                Message = this.Data,
                Text = this.ShowTime ? $"[{dateTime}] " : "" + this.Data,
                ShowDateTime = this.ShowTime
            };
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public void SetData(string Data)
        {
            this.Data = Data;
        }

        public void SetShowTime(bool ShowTime)
        {
            this.ShowTime = ShowTime;
        }

        ~LogBuilder()
        {
            Dispose();
        }
    }
}
