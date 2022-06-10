using System.Linq;

using fastLPI.tools.decompiler.data.digest;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentPackagesBuilder
    {
        private static readonly string[] Filter = new string[]
        {
            "META-INF",
            "icon"
        };

        public JarFileDigest JarFileDigest
        { get; set; }

        public JarDocumentPackagesBuilder(JarFileDigest JarFileDigest)
        {
            this.JarFileDigest = JarFileDigest;
        }

        public PackageCollector BuildPackages()
        {
            PackageCollector outputValue = new PackageCollector();

            foreach (JarDocumentItem item in this.JarFileDigest.GetDigest()) 
            {
                if (!ContainsInNamesFilter(item.Package) && !outputValue.ContainsPackage(item.Package) &&
                    item.ItemType != JarDocumentItemType.Resource)
                {
                    Package package = new Package(item.Package);
                    package.AddJarDocumentItem(item);
                    outputValue.Add(package);
                }
                else
                {
                    Package package = outputValue.GetPackage(item.Package);
                    if (package != null)
                        package.AddJarDocumentItem(item);
                }
            }

            return outputValue;
        }

        private static bool ContainsInNamesFilter(string itemName)
        {
            return Filter.Contains(itemName);
        }
    }
}
