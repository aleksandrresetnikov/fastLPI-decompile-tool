using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    public class JarFile : IJarFile, IChildItemsQueueChanges
    {
        /// <summary>
        /// Path to xml file.
        /// </summary>
        public string XmlPath
        { get; private protected set; }

        /// <summary>
        /// .jar file save properties.
        /// </summary>
        public virtual JarDocumentLoadingProperties DocumentLoadingProperties
        { get; private protected set; }

        /// <summary>
        /// Child items.
        /// </summary>
        public Queue<JarDocumentItem> ChildItems
        { get; set; }

        /// <summary>
        /// Document properties data.
        /// </summary>
        public JarDocumentProperties DocumentProperties
        { get; private protected set; }

        public JarFile(string XmlPath)
        {
            this.XmlPath = XmlPath;
        }

        public JarFile(string XmlPath, JarDocumentLoadingProperties DocumentProperties)
        {
            this.XmlPath = XmlPath;
            this.DocumentLoadingProperties = DocumentProperties;
        }

        public JarFile(string XmlPath, JarDocumentLoadingProperties DocumentProperties, Queue<JarDocumentItem> ChildItems)
        {
            this.XmlPath = XmlPath;
            this.DocumentLoadingProperties = DocumentProperties;
            this.ChildItems = ChildItems;
        }

        public JarFile(string XmlPath, JarDocumentLoadingProperties DocumentProperties, Queue<JarDocumentItem> ChildItems,
            JarDocumentProperties JarDocumentProperties)
        {
            this.XmlPath = XmlPath;
            this.DocumentLoadingProperties = DocumentProperties;
            this.ChildItems = ChildItems;
            this.DocumentProperties = JarDocumentProperties;
        }

        #region IJarFile
        public void SetXmlPath(string XmlPath)
        {
            this.XmlPath = XmlPath;
        }

        public void SetDocumentProperties(JarDocumentLoadingProperties DocumentProperties)
        {
            this.DocumentLoadingProperties = DocumentProperties;
        }

        public void SetChildItems(Queue<JarDocumentItem> ChildItems)
        {
            this.ChildItems = ChildItems;
        }

        public void SetJarDocumentProperties(JarDocumentProperties JarDocumentProperties)
        {
            this.DocumentProperties = JarDocumentProperties;
        }
        #endregion

        #region IChildItemsQueueChanges
        public int GetChildItemsCount()
        {
            return this.ChildItems.Count;
        }

        public bool GetContainsChildItems(JarDocumentItem item)
        {
            return this.ChildItems.Contains(item);
        }

        public void ChildItemsCopyTo(JarDocumentItem[] array, int arrayIndex)
        {
            this.ChildItems.CopyTo(array, arrayIndex);
        }

        public JarDocumentItem DequeueChildItems()
        {
            return this.ChildItems.Dequeue();
        }

        public void EnqueueChildItems(JarDocumentItem item)
        {
            this.ChildItems.Enqueue(item);
        }

        public Queue<JarDocumentItem>.Enumerator GetChildItemsEnumerator()
        {
            return this.ChildItems.GetEnumerator();
        }

        public JarDocumentItem PeekChildItems()
        {
            return this.ChildItems.Peek();
        }

        public JarDocumentItem[] ChildItemsToArray()
        {
            return this.ChildItems.ToArray();
        }

        public void ChildItemsTrimExcess()
        {
            this.ChildItems.TrimExcess();
        }
        #endregion
    }
}
