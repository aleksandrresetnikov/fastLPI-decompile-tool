﻿using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    [System.Serializable]
    public class Package : IPackage
    {
        /// <summary>
        /// Package name.
        /// </summary>
        public string PackageName
        { get; private protected set; }

        /// <summary>
        /// Items included in this Package.
        /// </summary>
        public Queue<JarDocumentItem> JarDocumentItems
        { get; private protected set; }

        public Package(string PackageName)
        {
            this.PackageName = PackageName;
            this.JarDocumentItems = new Queue<JarDocumentItem>();
        }

        public Package(string PackageName, Queue<JarDocumentItem> JarDocumentItems)
        {
            this.PackageName = PackageName;
            this.JarDocumentItems = JarDocumentItems;
        }

        public void SetPackageName(string PackageName)
        {
            this.PackageName = PackageName;
        }

        public JarDocumentItem GetJarDocumentItem(string JarDocumentItemName)
        {
            foreach (JarDocumentItem item in this.JarDocumentItems)
                if (item.ItemName == JarDocumentItemName)
                    return item;

            return null;
        }

        public Queue<JarDocumentItem> FilterJarDocumentItems(JarDocumentItemType filter)
        {
            Queue<JarDocumentItem> outputValue = new Queue<JarDocumentItem>();

            foreach (JarDocumentItem item in this.JarDocumentItems)
                if (item.ItemType == filter)
                    outputValue.Enqueue(item);

            return outputValue;
        }

        public void SetJarDocumentItems(Queue<JarDocumentItem> JarDocumentItems)
        {
            this.JarDocumentItems = JarDocumentItems;
        }

        public void AddJarDocumentItem(JarDocumentItem JarDocumentItem)
        {
            this.JarDocumentItems.Enqueue(JarDocumentItem);
        }

        public override string ToString()
        {
            return this.PackageName;
        }
    }
}
