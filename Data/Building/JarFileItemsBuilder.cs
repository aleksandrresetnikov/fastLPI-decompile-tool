using System;
using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarFileItemsBuilder
    {
        public static bool PrintProcessingItem = false;

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

        ulong step = 0;
        private protected virtual Queue<JarDocumentItem> GetSubItems(XElement item, string tab = "", 
            JarDocumentItem ParentDocumentItem = null)
        {
            //tab = tab.Replace(".", "\\");

            Queue<JarDocumentItem> OutputValue = new Queue<JarDocumentItem>();

            foreach (XElement subItem in item.Elements())
            {
                if (subItem.Name == JarDocumentLoadingPropertiesBuilder.LpiDataSavingPropertiesItemName) continue;

                JarElementBuilder ElementBuilder = new JarElementBuilder(subItem, tab);
                JarDocumentItem SubItem = ElementBuilder.BuildItem();
                JarDocumentItemTypeBuilder DocumentItemTypeBuilder = new JarDocumentItemTypeBuilder(SubItem, ParentDocumentItem, subItem.Elements().Count() > 0);
                JarDocumentItemPackageBuilder DocumentItemPackageBuilder = new JarDocumentItemPackageBuilder(SubItem, ParentDocumentItem);
                JarDocumentAccessLevelBuilder DocumentAccessLevelBuilder = new JarDocumentAccessLevelBuilder(subItem);

                SubItem.SetItemType(DocumentItemTypeBuilder.BuildItemType());
                SubItem.SetParentDocumentItem(ParentDocumentItem);
                SubItem.SetChildItems(GetSubItems(subItem, tab + ElementBuilder.ItemContext + "\\", SubItem));
                SubItem.SetAccessLevel(DocumentAccessLevelBuilder.BuildAccessLevel());
                SubItem.SetPackage(DocumentItemPackageBuilder.BuildPackage());

                if (PrintProcessingItem) Console.WriteLine($"#{++step} - {SubItem.GetFullName()}");
                //ElementBuilder.PrintItemLocationPath();

                OutputValue.Enqueue(SubItem);
            }

            return OutputValue;
        }
    }
}
