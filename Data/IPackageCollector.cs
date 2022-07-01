namespace fastLPI.tools.decompiler.data
{
    public interface IPackageCollector
    {
        bool ContainsPackage(string PackageName);
        Package GetPackage(string PackageName);
        Package GetPackage(Package item);
        bool DeletePackage(string PackageName);
        System.Collections.Generic.Queue<Package> GetQueueInstance();
    }
}
