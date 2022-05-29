namespace fastLPI.tools.decompiler.helper
{
    public static class SavingUtil
    {
        public static string GetDefaultOutputDataFileResultPath(this string InputJarFilePath) => 
            InputJarFilePath.RemoveExtension() + ".data";
    }
}
