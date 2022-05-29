namespace fastLPI.tools.decompiler.data
{
    /// <summary>
    ///  Properties for the jar file (in the form of properties for the jar document).
    ///  Because data about the .jar file is loaded in the form of a document, this 
    ///concept will be referred to as "document".
    /// </summary>
    [System.Serializable()]
    public class JarDocumentProperties
    {
        /// <summary>
        /// The name of the .jar document file.
        /// </summary>
        public string DocumentName
        { get; set; }

        /// <summary>
        /// The size of the .jar document file.
        /// </summary>
        public long DocumentSize
        { get; set; }

        /// <summary>
        /// The items length of the .jar document file.
        /// </summary>
        public int DocumentItemsLength
        { get; set; }

        /// <summary>
        /// The items full length (all items) of the .jar document file.
        /// </summary>
        public int DocumentItemsFullLength
        { get; set; }
    }
}
