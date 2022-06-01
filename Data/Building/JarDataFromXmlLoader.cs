using System;
using System.Xml.Linq;

using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDataFromXmlLoader : IJarDataFromXmlBuilder
    {
        /// <summary>
        /// Path to xml file.
        /// </summary>
        public string XmlPath
        { get; private set; }

        /// <summary>
        /// Xml file.
        /// </summary>
        public XElement XmlFile
        { get; private protected set; }

        private protected JarFileItemsBuilder ItemsBuilder;
        private protected JarDocumentLoadingPropertiesBuilder LoadingPropertiesBuilder;
        private protected JarDocumentPropertiesBuilder PropertiesBuilder;

        public JarDataFromXmlLoader(string XmlPath)
        {
            this.XmlPath = XmlPath;
            this.XmlFile = XElement.Load(this.XmlPath);
        }

        public void SetXmlPath(string XmlPath)
        {
            this.XmlPath = XmlPath;
        }

        public XElement GetXmlFile()
        {
            return this.XmlFile;
        }

        public JarFile BuildDocument()
        {
            try
            {
                this.LoadingPropertiesBuilder = new JarDocumentLoadingPropertiesBuilder(this.XmlFile);

                this.ItemsBuilder = new JarFileItemsBuilder(this.XmlFile);

                this.PropertiesBuilder = new JarDocumentPropertiesBuilder(this.XmlFile,
                    this.LoadingPropertiesBuilder.Build());

                JarDocumentLoadingProperties DocumentLoadingProperties = this.LoadingPropertiesBuilder.Build();
                return new JarFile(this.XmlPath, DocumentLoadingProperties,
                    this.ItemsBuilder.BuildChildItems(), this.PropertiesBuilder.BuildDocumentProperties());
            }
            catch (Exception ex)
            {
                Dump.AddDump("JarDataFromXmlLoader",
                    "\n\n\tJarDataFromXmlLoader\\BuildDocument" +
                    "\nXmlItem::Value = " + this.XmlFile.Value +
                    "\nXmlItem::BaseUri = " + this.XmlFile.BaseUri +
                    "\nXmlPath = " + this.XmlPath +
                    "\n\tStackTrace: \n" + ex.StackTrace, true);

                return null;
            }
        }
    }
}
