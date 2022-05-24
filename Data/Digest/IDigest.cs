using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.digest
{
    public interface IDigest<T>
    {
        IEnumerable<T> GetEnumerable();
        IEnumerable<T> GetDigest();

        void SetEnumerable(IEnumerable<T> Collection);
    }
}
