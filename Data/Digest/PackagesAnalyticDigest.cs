using System.Collections.Generic;
using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.digest
{
    public class PackagesAnalyticDigest : IPackagesAnalyticDigest
    {
        public PackageCollector PackageCollector
        { get; private set; }

        public PackagesAnalyticDigest(PackageCollector PackageCollector)
        {
            this.PackageCollector = PackageCollector;
        }

        public Queue<JarDocumentItem> GetPackageJarDocumentItems(string PackageName)
        {
            return PackageCollector.GetPackage(PackageName).JarDocumentItems;
        }

        /// <summary>
        /// Returns a set of JarDocumentItems based on the package import context.
        /// 
        /// Example 1:
        ///     value: javax.swing.JFrame
        ///     return: JFrame
        ///     
        /// Example 2:
        ///     value: javax.swing.*
        ///     return: { JButton, JFrame, JLabel, JPanel, JScrollPane, JTextArea, JApplet, etc... }
        /// </summary>
        /// <param name="PackageImportNameContext">Context with package import(import javax.swing.JFrame)</param>
        /// <returns></returns>
        public Queue<JarDocumentItem> GetPackageJarDocumentItemsFromImportReference(string ImportReference)
        {
            return new PackageJarDocumentItemsFromImportReferenceManager(PackageCollector, ImportReference)
                .GetJarDocumentItems();
        }

        public Queue<JarDocumentItem> GetPackageJarDocumentItemsFromImportReference(string[] ImportReferences)
        {
            Queue<JarDocumentItem> outputValue = new Queue<JarDocumentItem>();

            foreach (string ImportReference in ImportReferences)
                if (ImportReference != null && ImportReference != "") 
                    outputValue.EnqueueRange(new PackageJarDocumentItemsFromImportReferenceManager(PackageCollector, ImportReference)
                        .GetJarDocumentItems().ToArray());

            return outputValue;
        }

        public void SetPackageCollector(PackageCollector PackageCollector)
        {
            this.PackageCollector = PackageCollector;
        }
    }

    public class PackageJarDocumentItemsFromImportReferenceManager
    {
        public readonly static string ClassImportReferencePattern = @"(\w+?|\.+?|\*+?)*";

        public PackageCollector PackageCollector
        { get; set; }

        public string ImportReference
        { get; set; }

        public PackageJarDocumentItemsFromImportReferenceManager(PackageCollector PackageCollector,
            string ImportReference)
        {
            this.PackageCollector = PackageCollector;
            this.ImportReference = ImportReference;
        }

        public Queue<JarDocumentItem> GetJarDocumentItems()
        {
            string package = Util.GetPackageNameFromReference(this.ImportReference);
            Queue<JarDocumentItem> outputValue = new Queue<JarDocumentItem>();
            Package packageItem = this.PackageCollector.GetPackage(package);

            if (packageItem == null || !Regex.IsMatch(this.ImportReference, ClassImportReferencePattern)) return outputValue;

            if (this.ImportReference.Contains("*"))
            {
                foreach (JarDocumentItem item in packageItem.FilterJarDocumentItems(JarDocumentItemType.Class))
                    outputValue.Enqueue(item);
            }
            else 
            {
                outputValue.Enqueue(this.PackageCollector.GetPackage(package).GetJarDocumentItem
                    (this.ImportReference.Replace(package, "").Replace(".", "")));
            }

            return outputValue;
        }
    }
}
