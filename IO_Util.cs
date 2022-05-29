using System;
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

        public const string ClassExtension = ".class";
        public static bool IsClassFile(this string val, string Extension = ClassExtension)
        {
            /*return (val.Length >= ClassExtension.Length &&
                val[val.Length - 6] == '.' &&
                val[val.Length - 5] == 'c' &&
                val[val.Length - 4] == 'l' &&
                val[val.Length - 3] == 'a' &&
                val[val.Length - 2] == 's' &&
                val[val.Length - 1] == 's');*/
            try
            {
                if (val.Length < ClassExtension.Length || !val.Contains(ClassExtension)) return false;
                bool state = false;
                for (int i = 1; i < Extension.Length; i++)
                {
                    if (val[val.Length - i] == Extension[Extension.Length - i])
                        state = true;
                    else
                        return false;
                }
                return state;
            }
            catch (Exception)
            { return false; }
        }

        public static string RemoveExtension(this string path) => Path.ChangeExtension(path, null);
    }
}
