using System.Diagnostics;

namespace fastLPI.tools.decompiler
{
    public interface IJavaDecompiler
    {
        string GetPathIn();
        string GetPathTo();
        string GetDecompilerBatPath();
        string GetDecompilerExeBatPath();
        string GetDecompilerPath();
        Process GetDecompilerProcess();
        void Decompile(bool insertFile = false);
        bool GetCreateNoWindow();
    }
}
