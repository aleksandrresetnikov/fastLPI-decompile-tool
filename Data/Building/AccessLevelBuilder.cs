using System;
using System.Xml.Linq;

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
                return AccessLevelFlags.Error;
            }
        }
    }
}
