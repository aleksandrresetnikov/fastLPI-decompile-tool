namespace fastLPI.tools.decompiler.helper
{
    public static class QueueCollectionsUtil
    {
        public static void DeleteQueueItem<T>(this System.Collections.Generic.Queue<T> queue, T item)
        {
            System.Collections.Generic.Queue<T> outputQueue = new System.Collections.Generic.Queue<T>();

            foreach (T _item in queue)
                if (!_item.Equals(item))
                    outputQueue.Enqueue(_item);

            queue.Clear();
            foreach (T _item in outputQueue)
                queue.Enqueue(_item);
        }
        public static void EnqueueRange<T>(this System.Collections.Generic.Queue<T> queue, T[] items)
        {
            foreach (T _item in items)
                queue.Enqueue(_item);
        }
    }
}
