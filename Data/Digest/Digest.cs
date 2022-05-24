using System;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.digest
{
    public class Digest<T> : IDigest<T>
    {
        private protected virtual IEnumerable<T> Collection
        { get; set; }

        public Digest(IEnumerable<T> Collection) =>
            this.Collection = Collection;

        public virtual IEnumerable<T> GetDigest() =>
            throw new Exception();

        public virtual IEnumerable<T> GetEnumerable() =>
            this.Collection;

        public virtual void SetEnumerable(IEnumerable<T> Collection) =>
            this.Collection = Collection;
    }
}
