using System.Xml.Linq;
using System.Collections.Generic;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarFileItemsBuilder
    {
        /// <summary>
        /// Xml file.
        /// </summary>
        public XElement XmlFile
        { get; private protected set; }

        public JarFileItemsBuilder(XElement XmlFile)
        {
            this.XmlFile = XmlFile;
        }

        public virtual Queue<JarDocumentItem> BuildChildItems()
        {
            return this.GetSubItems(this.XmlFile);
        }

        private protected virtual Queue<JarDocumentItem> GetSubItems(XElement item, string tab = "", JarDocumentItem ParentDocumentItem = null)
        {
            Queue<JarDocumentItem> OutputValue = new Queue<JarDocumentItem>();

            foreach (XElement subItem in item.Elements())
            {
                if (subItem.Name == JarDocumentLoadingPropertiesBuilder.LpiDataSavingPropertiesItemName) continue;

                JarElementBuilder ElementBuilder = new JarElementBuilder(subItem, tab);
                JarDocumentItem SubItem = ElementBuilder.BuildItem();
                JarDocumentItemTypeBuilder DocumentItemTypeBuilder = new JarDocumentItemTypeBuilder(SubItem, ParentDocumentItem);

                SubItem.SetItemType(DocumentItemTypeBuilder.BuildItemType());
                SubItem.SetParentDocumentItem(ParentDocumentItem);
                SubItem.SetChildItems(GetSubItems(subItem, tab + ElementBuilder.ItemContext + "\\", SubItem));

                //ElementBuilder.PrintItemLocationPath();

                OutputValue.Enqueue(SubItem);
            }

            return OutputValue;
        }
    }
}
