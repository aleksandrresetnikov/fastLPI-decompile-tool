using System.IO;

namespace fastLPI.tools.decompiler
{
    public static class IO_Util
    {
        public static string ReplaceFileName(this string FilePath, string oldValue, string newValue)
        {
            FileInfo FileInfo = new FileInfo(FilePath);
            return $"{FileInfo.Directory.FullName}\\{FileInfo.Name.Replace(oldValue, newValue)}";
        }
    }
}
