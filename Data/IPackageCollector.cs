namespace fastLPI.tools.decompiler.data
{
    public interface IPackageCollector
    {
        bool ContainsPackage(string PackageName);
        Package GetPackage(string PackageName);
    }
}
