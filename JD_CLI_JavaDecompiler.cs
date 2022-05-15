using System;
using System.Diagnostics;
using System.IO;

namespace fastLPI.tools.decompiler
{
    public class JD_CLI_JavaDecompiler : JavaDecompiler
    {
        public static string GetLokationFolder() => (Environment.CurrentDirectory);

        private protected override string DecompilerBatPath 
        { get => $@"{GetLokationFolder()}\decompiler\ProgDecompiler.bat"; }

        private protected override string DecompilerExeBatPath 
        { get => $@"{GetLokationFolder()}\decompiler\ExeProgDecompiler.bat"; }

        private protected override string DecompilerPath 
        { get => $@"{GetLokationFolder()}\decompiler\jd-cli.jar"; }

        public virtual DecompilerProperties Properties
        { get; set; }

        public long DecompileLeadTime 
        { get; private protected set; }

        private Stopwatch Stopwatch;

        public JD_CLI_JavaDecompiler(string InputPath, string OutputPath)
        {
            this.PathIn = InputPath;
            this.PathTo = OutputPath;

            this.Properties = new DecompilerProperties(new JD_CLI_Dictionary());
            this.Stopwatch = new Stopwatch();
        }

        public override void Decompile(bool insertFile = false)
        {
            if (!insertFile && (File.Exists(this.PathTo))) return;

            this.Stopwatch.Restart();

            CreateDecompilerExeBatFile();
            InitDecompilerProcess();

            this.Stopwatch.Stop();
            this.DecompileLeadTime = this.Stopwatch.ElapsedMilliseconds;
        }

        private protected virtual void CreateDecompilerExeBatFile()
        {
            string BatCode = File.ReadAllText(DecompilerBatPath);
            BatCode = BatCode.Replace("$$$FILEPATH$$$", $"\"%{PathIn}%\"");
            BatCode = BatCode.Replace("$$$OUTPATH$$$", $"\"%{PathTo}%\"");
            BatCode = BatCode.Replace("$$$DECOMPILERJARPATH$$$", DecompilerPath);
            BatCode = BatCode.Replace("$$$OPTIONS$$$", Properties.CompileDecompilerOptions());
            File.WriteAllText(DecompilerExeBatPath, BatCode);

        }

        private protected virtual void InitDecompilerProcess()
        {
            this.DecompilerProcess = new Process();
            this.DecompilerProcess.StartInfo.FileName = this.DecompilerExeBatPath;
            this.DecompilerProcess.StartInfo.CreateNoWindow = this.CreateNoWindow;
            this.DecompilerProcess.StartInfo.UseShellExecute = false;
            this.DecompilerProcess.Start();
            this.DecompilerProcess.WaitForExit();
            File.Delete(this.DecompilerExeBatPath);
        }
    }
}
