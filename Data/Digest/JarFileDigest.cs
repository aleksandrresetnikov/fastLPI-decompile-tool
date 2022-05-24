using System;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.digest
{
    public class JarFileDigest : Digest<JarDocumentItem>, IDigestPrinter
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

        public override IEnumerable<JarDocumentItem> GetDigest() =>
            this.MakeDigest(this.QueueCollection);

        public override IEnumerable<JarDocumentItem> GetEnumerable() =>
            this.QueueCollection;

        public override void SetEnumerable(IEnumerable<JarDocumentItem> Collection) =>
            this.QueueCollection = (Collection as Queue<JarDocumentItem>);

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

        public void PrintDigest()
        {
            foreach (JarDocumentItem item in this.GetDigest())
                Console.WriteLine(item.ItemName);
        }
    }
}
