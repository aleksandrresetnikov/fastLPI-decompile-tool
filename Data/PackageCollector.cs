using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    [System.Serializable]
    public class PackageCollector : List<Package>, IPackageCollector
    {
        public virtual bool ContainsPackage(string PackageName)
        {
            foreach (Package item in this)
                if (item.PackageName == PackageName)
                    return true;

            return false;
        }

        public virtual Package GetPackage(string PackageName)
        {
            foreach (Package item in this)
                if (item.PackageName == PackageName)
                    return item;

            return null;
        }
    }
}
