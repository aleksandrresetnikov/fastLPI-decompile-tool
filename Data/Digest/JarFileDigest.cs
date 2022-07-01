using System;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.digest
{
    public class JarFileDigest : Digest<JarDocumentItem>, IDigestPrinter, IJarFileDigestGeneralAnalyzer, IJarFileDigestFilter
    {
        private Queue<JarDocumentItem> QueueCollection;

        private protected override IEnumerable<JarDocumentItem> Collection
        {
            get => this.QueueCollection;
            set => this.QueueCollection = (value as Queue<JarDocumentItem>);
        }

        public JarFileDigest(Queue<JarDocumentItem> QueueJarFileCollection)
            : base(QueueJarFileCollection) =>
            this.QueueCollection = QueueJarFileCollection;

        public override IEnumerable<JarDocumentItem> GetDigest()
        {
            return this.MakeDigest(this.QueueCollection);
        }

        public override IEnumerable<JarDocumentItem> GetEnumerable()
        {
            return this.QueueCollection;
        }

        public override void SetEnumerable(IEnumerable<JarDocumentItem> Collection)
        {
            this.QueueCollection = (Collection as Queue<JarDocumentItem>);
        }

        protected virtual Queue<JarDocumentItem> MakeDigest(Queue<JarDocumentItem> QueueCollection)
        {
            Queue<JarDocumentItem> OutputValue = new Queue<JarDocumentItem>();

            foreach (JarDocumentItem item in QueueCollection)
            {
                OutputValue.Enqueue(item);

                if (item.GetChildItemsCount() > 0)
                    foreach (JarDocumentItem item2 in this.MakeDigest(item.ChildItems))
                        OutputValue.Enqueue(item2);
            }

            return OutputValue;
        }

        public void PrintDigest(JarDocumentItemType filter = JarDocumentItemType.Class)
        {
            foreach (JarDocumentItem item in this.GetDigest())
                if (item.ItemType == filter)
                //if (item.AccessLevelManager.IsClass())
                Console.WriteLine($"Name: {/*item.ItemName*//*item.ItemLocationPath*//*item.GetFullName()*/item.GetContactName()}; " +
                    $"Package: {item.Package}; " +
                    $"Child items count: {item.ChildItems.Count}"/* +
                    $"Location path: {item.ItemLocationPath}" +
                    $"Access level: {item.AccessLevel}; " +
                    $"Type: {item.AccessLevelManager.AccessLevel.ToString()}; " +
                    $"Type parent: {(item.ParentDocumentItem != null ? item.ParentDocumentItem.ItemType.ToString() : "Root")};"*/);
        }

        #region IJarFileDigestGeneralAnalyzer
        public Queue<JarDocumentItem> GetClasses()
        {
            return GetFilterItems(JarDocumentItemType.Class);
        }

        public Queue<JarDocumentItem> GetMethods()
        {
            return GetFilterItems(JarDocumentItemType.Method);
        }

        public Queue<JarDocumentItem> GetClassFiles()
        {
            return GetFilterItems(JarDocumentItemType.ClassFile);
        }

        public Queue<JarDocumentItem> GetConstructors()
        {
            return GetFilterItems(JarDocumentItemType.Constructor);
        }

        public Queue<JarDocumentItem> GetFields()
        {
            return GetFilterItems(JarDocumentItemType.Field);
        }

        public Queue<JarDocumentItem> GetPackageItems()
        {
            return GetFilterItems(JarDocumentItemType.PackageItem);
        }
        #endregion

        #region IJarFileDigestFilter
        public Queue<JarDocumentItem> GetFilterItems(JarDocumentItemType filter)
        {
            Queue<JarDocumentItem> outputValue = new Queue<JarDocumentItem>();

            foreach (JarDocumentItem item in this.GetDigest())
                if (item.ItemType == filter)
                    outputValue.Enqueue(item);

            return outputValue;
        }
        #endregion
    }
}
