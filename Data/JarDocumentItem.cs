using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    [System.Serializable()]
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

        private protected AccessLevelFlags _AccessLevel;
        /// <summary>
        /// Item access level.
        /// </summary>
        public AccessLevelFlags AccessLevel
        { 
            get 
            {
                return this._AccessLevel;
            } 
            private protected set
            {
                this._AccessLevel = value;
                this.AccessLevelManager = new AccessLevelManager(this._AccessLevel);
            }
        }

        private protected AccessLevelManager _AccessLevelManager;
        /// <summary>
        /// Item access level helper manager.
        /// </summary>
        public AccessLevelManager AccessLevelManager
        {
            get
            {
                if (this._AccessLevelManager == null) 
                    this._AccessLevelManager = new AccessLevelManager(this._AccessLevel);
                return this._AccessLevelManager;
            }
            private protected set
            {
                this._AccessLevelManager = value;
            } 
        }

        /// <summary>
        /// Item package.
        /// </summary>
        public string Package
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
            string TabPath, string Package)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
            this.TabPath = TabPath;
            this.Package = Package;
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

        public JarDocumentItem(string ItemName, string ItemLocationPath, string ItemContext,
            JarDocumentItem ParentDocumentItem, string TabPath, string Package)
        {
            this.ItemName = ItemName;
            this.ItemLocationPath = ItemLocationPath;
            this.ItemContext = ItemContext;
            this.ParentDocumentItem = ParentDocumentItem;
            this.TabPath = TabPath;
            this.Package = Package;
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

        public void SetAccessLevel(AccessLevelFlags AccessLevel)
        {
            this.AccessLevel = AccessLevel;
        }

        public void SetPackage(string Package)
        {
            this.Package = Package;
        }

        public string GetSubackage()
        {
            if (this.ParentDocumentItem == null)
                return "#none";
            return this.ParentDocumentItem.Package;
        }

        public string GetFullName()
        {
            return $"{this.Package}.{GetSubFullName(this)}";
        }

        public string GetContactName()
        {
            return $"{GetSubFullName(this)}";
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

        #region helper
        private static string GetSubFullName(JarDocumentItem item)
        {
            if (item.ParentDocumentItem != null && item.ParentDocumentItem.ItemType == JarDocumentItemType.Class)
                return $"{GetSubFullName(item.ParentDocumentItem)}.{item.ItemName}";
            else
                return item.ItemName;
        }

        public override string ToString()
        {
            return this.ItemName;
        }
        #endregion
    }
}
