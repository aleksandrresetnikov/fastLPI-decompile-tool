namespace fastLPI.tools.decompiler.data.saving
{
    public interface IJarDataLoadManager
    {
        void SetPath(string Path);
        JarFile Load();
    }
}
