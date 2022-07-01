namespace fastLPI.tools.decompiler.data.digest
{
    public interface IJarFileDigestFilter
    {
        System.Collections.Generic.Queue<JarDocumentItem> GetFilterItems(JarDocumentItemType filter);
    }
}
