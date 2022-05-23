using System;
using System.Xml.Linq;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarElementBuilder
    {
        /// <summary>
        /// Xml item.
        /// </summary>
        public XElement XmlItem
        { get; private protected set; }

        /// <summary>
        /// Xml item name.
        /// </summary>
        public XName XmlItemName
        { get => XmlItem.Name; }

        /// <summary>
        /// Xml item context.
        /// </summary>
        public string ItemContext
        { get => this.XmlItemName.LocalName.RecognizeItemContext(); }

        /// <summary>
        /// Xml item name.
        /// </summary>
        public string ItemName
        { get => this.XmlItemName.LocalName.RecognizeItemContext(); }

        /// <summary>
        /// Xml tab item.
        /// </summary>
        public string PathTab
        { get; private protected set; }

        /// <summary>
        /// Xml item location path.
        /// </summary>
        public string ItemLocationPath
        { get => this.PathTab + this.ItemName; }

        public JarElementBuilder(XElement XmlItem)
        {
            this.XmlItem = XmlItem;
            this.PathTab = "";
        }

        public JarElementBuilder(XElement XmlItem, string PathTab)
        {
            this.XmlItem = XmlItem;
            this.PathTab = PathTab;
        }

        public virtual JarDocumentItem BuildItem()
        {
            return new JarDocumentItem(this.ItemName,
                this.ItemLocationPath, this.ItemContext);
        }

        public virtual void PrintItemLocationPath()
        {
            Console.WriteLine(this.PathTab + this.ItemContext);
        }
    }
}
