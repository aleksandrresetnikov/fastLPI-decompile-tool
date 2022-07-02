using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;

using fastLPI.tools.decompiler.helper;
using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler
{
    //https://github.com/intoolswetrust/jd-cli
    //https://github.com/betterphp/JDCommandLine
    //https://github.com/nviennot/jd-core-java

    public class JD_CLI_JavaDecompiler : JavaDecompiler, IJD_CLI_JavaDecompiler, IJavaDecompilerLogs
    {
        private protected override string DecompilerBatPath 
        { get => $@"{Util.GetLokationFolder()}\decompiler\ProgDecompiler.bat"; }

        private protected override string DecompilerExeBatPath 
        { get => $@"{Util.GetLokationFolder()}\decompiler\ExeProgDecompiler.bat"; }

        private protected override string DecompilerPath 
        { get => $@"{Util.GetLokationFolder()}\decompiler\jd-cli.jar"; }

        public virtual DecompilerProperties Properties
        { get; set; }

        public long DecompileLeadTime 
        { get; private protected set; }

        public StreamReader DecompilerProcessReader
        { get; private protected set; }

        public string DecompilerProcessReaderOutputData
        { get; private protected set; }

        public LogsCollector Logs
        { get; private protected set; }

        private Stopwatch Stopwatch;

        public JD_CLI_JavaDecompiler(string InputPath, string OutputPath)
        {
            this.PathIn = InputPath;
            this.PathTo = OutputPath;

            this.Properties = new DecompilerProperties(new JD_CLI_Dictionary());
            this.Stopwatch = new Stopwatch();
            this.Logs = new LogsCollector();

            this.AddLog("Loaded.");
        }

        public override void Decompile(bool insertFile = false)
        {
            if (!insertFile && (File.Exists(this.PathTo))) return;

            this.Stopwatch.Restart();

            CreateDecompilerExeBatFile();
            InitDecompilerProcess();

            this.Stopwatch.Stop();
            this.DecompileLeadTime = this.Stopwatch.ElapsedMilliseconds;

            this.AddLog("Decompiling.");
        }

        public virtual void CreateDecompilerExeBatFile()
        {
            string BatCode = File.ReadAllText(DecompilerBatPath);
            BatCode = BatCode.Replace("$$$FILEPATH$$$", $"\"%{PathIn}%\"");
            BatCode = BatCode.Replace("$$$OUTPATH$$$", $"\"%{PathTo}%\"");
            BatCode = BatCode.Replace("$$$DECOMPILERJARPATH$$$", $"\"{DecompilerPath}\"");
            BatCode = BatCode.Replace("$$$OPTIONS$$$", Properties.CompileDecompilerOptions());
            File.WriteAllText(DecompilerExeBatPath, BatCode);

            this.AddLog("CreateDecompilerExeBatFile.");

        }

        public virtual void InitDecompilerProcess()
        {
            this.DecompilerProcess = new Process();

            this.DecompilerProcess.StartInfo.FileName = this.DecompilerExeBatPath;
            this.DecompilerProcess.StartInfo.CreateNoWindow = this.CreateNoWindow;
            this.DecompilerProcess.StartInfo.UseShellExecute = false;
            this.DecompilerProcess.StartInfo.RedirectStandardOutput = true;

            this.DecompilerProcess.Start();
            this.DecompilerProcessReader = this.DecompilerProcess.StandardOutput;

            UpdateDecompilerProcessReaderOutputData();
            File.Delete(this.DecompilerExeBatPath);

            this.AddLog("InitDecompilerProcess.");
        }

        public virtual void UpdateDecompilerProcessReaderOutputData()
        {
            this.DecompilerProcessReaderOutputData = this.DecompilerProcessReader.ReadToEnd();
        }

        public void AddLog(string data, bool showTime = false)
        {
            this.CheckLogsCollector();
            this.Logs.AddLog(data, showTime);
        }

        public List<string> GetLogs()
        {
            this.CheckLogsCollector();
            return this.Logs.GetLogs();
        }

        private void CheckLogsCollector()
        {
            if (this.Logs == null) this.Logs = new LogsCollector();
        }
    }
}
