using System;
using System.IO;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.diagnostics
{
    public class Dump
    {
        public delegate void Dumping(DumpEventArgs e);

        public static event Dumping EventOnAddDumpCall;
        public static event Dumping EventOnCreateDumpCall;
        public static event Dumping EventOnAddNewDumpCall;

        public static void AddDump(string path, string text, bool drawDate = false)
        {
            if (EventOnAddDumpCall != null)
                EventOnAddDumpCall.Invoke(new DumpEventArgs(path, text, drawDate));

            if (!LPI_Libs_Remastering_Dump.DumpPerformance) return;

            File.AppendAllText(LPI_Libs_Remastering_Dump.DumpPath + path + LPI_Libs_Remastering_Dump.DumpLogExtension, 
                (drawDate ? Util.GetDumpDate() : "") + text + Environment.NewLine);
        }

        public static void CreateDump(string path, string text, bool drawDate = false)
        {
            if (EventOnCreateDumpCall != null)
                EventOnCreateDumpCall.Invoke(new DumpEventArgs(path, text, drawDate));

            if (!LPI_Libs_Remastering_Dump.DumpPerformance) return;

            File.WriteAllText(LPI_Libs_Remastering_Dump.DumpPath + path + LPI_Libs_Remastering_Dump.DumpLogExtension, 
                (drawDate ? Util.GetDumpDate() : "") + text + Environment.NewLine);
        }

        public static void AddNewDump(string path, string text, bool drawDate = false)
        {
            if (EventOnAddNewDumpCall != null)
                EventOnAddNewDumpCall.Invoke(new DumpEventArgs(path, text, drawDate));

            if (!LPI_Libs_Remastering_Dump.DumpPerformance) return;

            string name = new FileInfo(LPI_Libs_Remastering_Dump.DumpPath + path).Name;

            File.WriteAllText(LPI_Libs_Remastering_Dump.DumpPath + @"\" + 
                Util.GetNewDumpName(name, LPI_Libs_Remastering_Dump.DumpPath) + LPI_Libs_Remastering_Dump.DumpLogExtension, text);
        }
    }
}
