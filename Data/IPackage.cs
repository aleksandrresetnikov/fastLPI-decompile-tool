namespace fastLPI.tools.decompiler.data
{
    public interface IPackage
    {
        void SetPackageName(string PackageName);
        void SetJarDocumentItems(System.Collections.Generic.Queue<JarDocumentItem> JarDocumentItems);
        JarDocumentItem GetJarDocumentItem(string JarDocumentItemName);
        System.Collections.Generic.Queue<JarDocumentItem> FilterJarDocumentItems(JarDocumentItemType filter);
        void AddJarDocumentItem(JarDocumentItem JarDocumentItem);
    }
}
