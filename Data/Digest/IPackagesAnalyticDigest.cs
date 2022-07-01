namespace fastLPI.tools.decompiler.data.digest
{
    public interface IPackagesAnalyticDigest
    {
        System.Collections.Generic.Queue<JarDocumentItem> GetPackageJarDocumentItems(string PackageName);
        System.Collections.Generic.Queue<JarDocumentItem> GetPackageJarDocumentItemsFromImportReference(string ImportNameContext);
        void SetPackageCollector(PackageCollector PackageCollector);
    }
}
