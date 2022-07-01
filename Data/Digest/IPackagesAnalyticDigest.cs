namespace fastLPI.tools.decompiler.data.digest
{
    public interface IPackagesAnalyticDigest
    {
        System.Collections.Generic.Queue<JarDocumentItem> GetPackageJarDocumentItems(string PackageName);
        System.Collections.Generic.Queue<JarDocumentItem> GetPackageJarDocumentItemsFromImportReference(string ImportReference);
        System.Collections.Generic.Queue<JarDocumentItem> GetPackageJarDocumentItemsFromImportReference(string[] ImportReferences);
        void SetPackageCollector(PackageCollector PackageCollector);
    }
}
