using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    public interface IJarDocumentItem
    {
        void SetItemLocationPath(string ItemLocationPath);
        void SetItemName(string ItemName);
        void SetItemContext(string ItemContext);
        void SetParentDocumentItem(JarDocumentItem ParentDocumentItem);
        void SetChildItems(Queue<JarDocumentItem> ChildItems);
        void SetItemType(JarDocumentItemType ItemType);
        void SetAccessLevel(AccessLevelFlags AccessLevel);
        void SetPackage(string Package);
        string GetSubackage();
        string GetFullName();
    }
}
