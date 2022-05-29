namespace fastLPI.tools.decompiler.data.saving
{
    public interface IJarDataInstance
    {
        JarFile GetDocument();
        JarDataInstanceProperties GetProperties();
        object GetData();
        System.Type GetDataType();
    }
}
