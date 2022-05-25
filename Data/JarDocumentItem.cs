using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    public class JarDocumentItem : IJarDocumentItem, IChildItemsQueueChanges
    {
        /// <summary>
        /// The path to the item.
        /// </summary>
        public string ItemLocationPath
        { get; private protected set; }

        /// <summary>
        /// Item name.
        /// </summary>
        public string ItemName
        { get; private protected set; }

        /// <summary>
        /// Item context.
        /// </summary>
        public string ItemContext
        { get; private protected set; }

        /// <summary>
        /// Item type.
        /// </summary>
        public JarDocumentItemType ItemType
        { get; private protected set; }

        /// <summary>
        /// The item's parent. Null if this is the root element.
        /// </summary>
        public JarDocumentItem ParentDocumentItem
        { get; private protected set; }

        /// <summary>
        /// Child items.
        /// </summary>
        public Queue<JarDocumentItem> ChildItems
        { get; private protected set; }

        /// <summary>
        /// Child items.
        /// </summary>
        public string TabPath
        { get; private protected set; }

        public JarDocumentItem(string ItemName)
        {
            this.ItemName = ItemName;
        }

        public JarDocumentItem(string ItemName, string ItemLocationPath)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
        }

        public JarDocumentItem(string ItemName, string ItemLocationPath, string ItemContext)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
        }

        public JarDocumentItem(string ItemName, string ItemLocationPath, string ItemContext, 
            string TabPath)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
            this.TabPath = TabPath;
        }

        public JarDocumentItem(string ItemName, string ItemLocationPath, string ItemContext, 
            JarDocumentItem ParentDocumentItem)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
            this.ParentDocumentItem = ParentDocumentItem;
        }

        public JarDocumentItem(string ItemName, string ItemLocationPath, string ItemContext, 
            JarDocumentItem ParentDocumentItem, string TabPath)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
            this.ParentDocumentItem = ParentDocumentItem;
            this.TabPath = TabPath;
        }

        #region IJarDocumentItem
        public void SetItemLocationPath(string ItemLocationPath)
        {
            this.ItemLocationPath = ItemLocationPath;
        }

        public void SetItemName(string ItemName)
        {
            this.ItemName = ItemName;
        }

        public void SetItemContext(string ItemContext)
        {
            this.ItemContext = ItemContext;
        }

        public void SetParentDocumentItem(JarDocumentItem ParentDocumentItem)
        {
            this.ParentDocumentItem = ParentDocumentItem;
        }

        public void SetChildItems(Queue<JarDocumentItem> ChildItems)
        {
            this.ChildItems = ChildItems;
        }

        public void SetItemType(JarDocumentItemType ItemType)
        {
            this.ItemType = ItemType;
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
