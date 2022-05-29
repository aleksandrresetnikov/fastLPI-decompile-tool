using System;

namespace fastLPI.tools.decompiler.data
{
    [Serializable]
    public class JarDocumentLoadingProperties
    {
        /// <summary>
        /// .jar file data saving time.
        /// </summary>
        public long SaveTime
        { get; set; }

        /// <summary>
        /// .jar file input path.
        /// </summary>
        public string InputPath
        { get; set; }

        /// <summary>
        /// .jar file output path.
        /// </summary>
        public string OutputPath
        { get; set; }

        /// <summary>
        /// .jar file name.
        /// </summary>
        public string JarFileName
        { get; set; }
    }
}
