using System;
using System.IO;
using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.helper;
using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentItemTypeBuilder
    {
        /// <summary>
        /// Item
        /// </summary>
        public JarDocumentItem Item
        { get; set; }

        /// <summary>
        /// Parent item
        /// </summary>
        public JarDocumentItem ParentItem
        { get; set; }

        public JarDocumentItemTypeBuilder(JarDocumentItem Item, JarDocumentItem ParentItem)
        {
            this.Item = Item;
            this.ParentItem = ParentItem;
        }

        static int Step = 0;
        public JarDocumentItemType BuildItemType()
        {
            try
            {
                string val = this.Item.ItemContext;
                //Console.WriteLine($"#{Step++}: {val}; Parent item type: {GetParentItemType()}");

                if (val.IsClassFile())
                    return JarDocumentItemType.ClassFile;

                else if (val.Contains("(") && val.Contains(")") && Regex.IsMatch(val, Patterns.MethodPattern) && 
                    this.ParentItem != null && this.ParentItem.ItemType == JarDocumentItemType.Class)
                    return JarDocumentItemType.Method;

                else if (Regex.IsMatch(val, Patterns.FieldPattern) && this.ParentItem != null &&
                    this.ParentItem.ItemType == JarDocumentItemType.Class)
                    return JarDocumentItemType.Field;

                else if (val.Contains("(") && val.Contains(")") && Regex.IsMatch(val, Patterns.ConstructorPattern) && 
                    this.ParentItem != null && this.ParentItem.ItemType == JarDocumentItemType.Class)
                    return JarDocumentItemType.Constructor;

                else if (this.ParentItem != null && (this.ParentItem.ItemType == JarDocumentItemType.ClassFile ||
                    this.ParentItem.ItemType == JarDocumentItemType.Class) && val.IsClass())
                    return JarDocumentItemType.Class;

                else if (val.Contains("."))
                    return JarDocumentItemType.Resource;

                else
                    return JarDocumentItemType.None;
            }
            catch (Exception ex)
            {
                Dump.AddDump("JarDocumentItemTypeBuilder",
                    "\n\n\tJarDocumentItemTypeBuilder\\BuildItemType" +
                    "\nItem::ItemName = " + this.Item.ItemName +
                    "\nItem::ItemContext = " + this.Item.ItemContext +
                    "\nItem::ItemLocationPath = " + this.Item.ItemLocationPath +
                    "\nItem::TabPath = " + (this.Item.TabPath != null ? this.Item.TabPath : "Root") +
                    "\n\tStackTrace: \n" + ex.StackTrace, true);
                return JarDocumentItemType.Error;
            }
        }

        private string GetParentItemType()
        {
            if (ParentItem == null) return "Root";
            else return ParentItem.ItemType.ToString();
        }
    }
}
