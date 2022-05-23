using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    public interface IChildItemsQueueChanges
    {
        int GetChildItemsCount();
        bool GetContainsChildItems(JarDocumentItem item);
        void ChildItemsCopyTo(JarDocumentItem[] array, int arrayIndex);
        JarDocumentItem DequeueChildItems();
        void EnqueueChildItems(JarDocumentItem item);
        Queue<JarDocumentItem>.Enumerator GetChildItemsEnumerator();
        JarDocumentItem PeekChildItems();
        JarDocumentItem[] ChildItemsToArray();
        void ChildItemsTrimExcess();
    }
}
