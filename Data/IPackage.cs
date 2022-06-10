namespace fastLPI.tools.decompiler.data
{
    public interface IPackage
    {
        void SetPackageName(string PackageName);
        void SetJarDocumentItems(System.Collections.Generic.Queue<JarDocumentItem> JarDocumentItems);
        void AddJarDocumentItem(JarDocumentItem JarDocumentItem);
    }
}
