using System.IO;

namespace fastLPI.tools.decompiler.helper
{
    public static class SavingUtil
    {
        public static string GetDefaultOutputDataFileResultPath(this string InputJarFilePath) => 
            new FileInfo(InputJarFilePath).Directory.FullName + @"\CacheData\" +
            new FileInfo(InputJarFilePath.RemoveExtension() + ".data").Name;
    }
}
