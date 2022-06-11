using System;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.digest
{
    public class JarFileDigest : Digest<JarDocumentItem>, IDigestPrinter, IJarFileDigestGeneralAnalyzer
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
                Console.WriteLine($"Name: {/*item.ItemName*//*item.ItemLocationPath*//*item.GetFullName()*/item.GetContactName()}; " +
                    $"Location path: {item.ItemLocationPath}"/* +
                    $"Access level: {item.AccessLevel}; " +
                    $"Package: {item.Package}; " +
                    $"Type: {item.ItemType.ToString()}; " +
                    $"Type parent: {(item.ParentDocumentItem != null ? item.ParentDocumentItem.ItemType.ToString() : "Root")};"*/);
        }

        #region IJarFileDigestGeneralAnalyzer
        public Queue<JarDocumentItem> GetClasses()
        {
            return GetFilterItems(JarDocumentItemType.Class);
        }

        public Queue<JarDocumentItem> GetMethods()
        {
            throw new NotImplementedException();
        }

        public Queue<JarDocumentItem> GetClassFiles()
        {
            throw new NotImplementedException();
        }

        public Queue<JarDocumentItem> GetConstructors()
        {
            throw new NotImplementedException();
        }

        public Queue<JarDocumentItem> GetFields()
        {
            throw new NotImplementedException();
        }

        public Queue<JarDocumentItem> GetPackageItems()
        {
            throw new NotImplementedException();
        }
        #endregion

        private Queue<JarDocumentItem> GetFilterItems(JarDocumentItemType filter)
        {
            Queue<JarDocumentItem> outputValue = new Queue<JarDocumentItem>();

            foreach (JarDocumentItem item in this.GetDigest())
                if (item.ItemType == filter)
                    outputValue.Enqueue(item);

            return outputValue;
        }
    }
}
