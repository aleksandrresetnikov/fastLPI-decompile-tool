using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.saving
{
    public class JarDataInstanceProperties : IJarDataInstanceProperties
    {
        /// <summary>
        /// The path to the file (.jar).
        /// </summary>
        public string FilePath
        { get; private protected set; }

        /// <summary>
        /// Path to the output .xml file.
        /// </summary>
        public string OutputXmlFileResultPath
        { get; private protected set; }

        /// <summary>
        /// The path to the output data result.
        /// </summary>
        public string OutputDataFileResultPath
        { get; private protected set; }
         
        public JarDataInstanceProperties(string FilePath, string OutputXmlFileResultPath)
        {
            this.FilePath = FilePath;
            this.OutputXmlFileResultPath = OutputXmlFileResultPath;
            this.OutputDataFileResultPath = GetDefaultOutputDataFileResultPath();
        }

        public JarDataInstanceProperties(string FilePath, string OutputXmlFileResultPath, string OutputDataFileResultPath)
        {
            this.FilePath = FilePath;
            this.OutputXmlFileResultPath = OutputXmlFileResultPath;
            this.OutputDataFileResultPath = OutputDataFileResultPath;
        }

        private protected virtual string GetDefaultOutputDataFileResultPath()
        {
            return this.FilePath.GetDefaultOutputDataFileResultPath();
        }

        public void SetExitXmlFileResultPath(string OutputXmlFileResultPath)
        {
            this.OutputXmlFileResultPath = OutputXmlFileResultPath;
        }

        public void SetFilePath(string FilePath)
        {
            this.FilePath = FilePath;
        }
    }
}
