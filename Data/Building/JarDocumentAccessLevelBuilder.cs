using System;
using System.Xml.Linq;

using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentAccessLevelBuilder
    {
        /// <summary>
        /// Xml item.
        /// </summary>
        public XElement XmlItem
        { get; private protected set; }

        public JarDocumentAccessLevelBuilder(XElement XmlItem)
        {
            this.XmlItem = XmlItem;
        }

        public AccessLevelFlags BuildAccessLevel()
        {
            try
            {
                return (AccessLevelFlags)Convert.ToInt32(XmlItem.Attribute("Flags").Value);
            }
            catch (Exception ex)
            {
                Dump.AddDump("JarDocumentAccessLevelBuilder", 
                    "\n\n\tJarDocumentAccessLevelBuilder\\BuildAccessLevel" +
                    "\nXmlItem::Value = " + this.XmlItem.Value +
                    "\nXmlItem::BaseUri = " + this.XmlItem.BaseUri +
                    "\nXmlItem::Document::Root::Value = " + this.XmlItem.Document.Root.Value +
                    "\nXmlItem::Document::Root::BaseUri = " + this.XmlItem.Document.Root.BaseUri +
                    "\n\tStackTrace: \n" + ex.StackTrace, true);
                return AccessLevelFlags.Error;
            }
        }
    }
}
