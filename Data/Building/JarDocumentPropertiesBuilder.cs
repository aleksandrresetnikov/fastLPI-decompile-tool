using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentPropertiesBuilder
    {
        /// <summary>
        /// Xml file.
        /// </summary>
        public XElement XmlFile
        { get; private protected set; }

        /// <summary>
        /// Loading properties
        /// </summary>
        public virtual JarDocumentLoadingProperties LoadingProperties
        { get; private protected set; }

        private protected FileInfo InputFileInfo;

        public JarDocumentPropertiesBuilder(XElement XmlFile, JarDocumentLoadingProperties LoadingProperties)
        {
            this.XmlFile = XmlFile;
            this.LoadingProperties = LoadingProperties;
            this.InputFileInfo = new FileInfo(this.LoadingProperties.OutputPath.ReplaceFileName("-data.xml", ""));
        }

        public virtual JarDocumentProperties BuildDocumentProperties()
        {
            return new JarDocumentProperties
            {
                DocumentName = this.InputFileInfo.Name,
                DocumentSize = this.InputFileInfo.Length,
                DocumentItemsLength = this.XmlFile.GetDocumentItemsLength(),
                DocumentItemsFullLength = this.XmlFile.GetDocumentItemsFullLength()
            };
        }
    }
}
