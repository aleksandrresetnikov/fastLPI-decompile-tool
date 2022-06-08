namespace fastLPI.tools.decompiler.data.digest
{
    public interface IDigestPrinter
    {
        void PrintDigest(JarDocumentItemType filter = JarDocumentItemType.Method);
    }
}
