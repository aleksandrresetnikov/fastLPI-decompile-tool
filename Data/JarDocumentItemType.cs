namespace fastLPI.tools.decompiler.data
{
    /// <summary>
    /// Element types in .jar file.
    /// 
    /// Types:
    ///     1. None - Not defined (default value).
    ///     2. PackageItem - Package item or folder.
    ///     3. Class - java class.
    ///     4. Method - java method.
    ///     5. Field - java field or variable.
    ///     6. ClassFile - .class in the jar file.
    ///     7. Resource - java resource (images, text, json. xml, and more...).
    /// </summary>
    public enum JarDocumentItemType
    {
        /// <summary>
        /// None - Not defined (default value).
        /// </summary>
        None,

        /// <summary>
        /// Package item or folder.
        /// </summary>
        PackageItem,

        /// <summary>
        /// java class.
        /// </summary>
        Class,

        /// <summary>
        /// java method.
        /// </summary>
        Method,

        /// <summary>
        /// java field or variable.
        /// </summary>
        Field,

        /// <summary>
        /// .class in the jar file.
        /// </summary>
        ClassFile,

        /// <summary>
        /// java resource (images, text, json. xml, and more...).
        /// </summary>
        Resource,

        /// <summary>
        /// java class constructor.
        /// </summary>
        Constructor,

        /// <summary>
        /// Definition error
        /// </summary>
        Error
    }
}
