using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentItemPackageBuilder
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

        public JarDocumentItemPackageBuilder(JarDocumentItem Item, JarDocumentItem ParentItem)
        {
            this.Item = Item;
            this.ParentItem = ParentItem;
        }

        public string BuildPackage()
        {
            return IteratingOverChildElements(this.Item);
        }

        private string IteratingOverChildElements(JarDocumentItem documentItem)
        {
            string outputValue = "";

            Stack<PackageItem> PackageTrain = new Stack<PackageItem>();
            Stack<JarDocumentItem> Pool = new Stack<JarDocumentItem>();
            Pool.Push(documentItem);

            while (Pool.Count > 0)
            {
                JarDocumentItem item = Pool.Pop();

                if (item.ParentDocumentItem != null) Pool.Push(item.ParentDocumentItem);

                PackageTrain.Push(new PackageItem { 
                    Name = $"{item.ItemName}." ,
                    Type = item.ItemType
                });
            }

            foreach (PackageItem item in PackageTrain)
            {
                if (item.Type == JarDocumentItemType.ClassFile ||    
                    item.Type == JarDocumentItemType.Error ||        
                    item.Type == JarDocumentItemType.Resource) break;
                outputValue += item.Name;
            }

            return outputValue.Remove(outputValue.Length - 1, 1);
        }
    }

    public class PackageItem
    {
        public string Name;
        public JarDocumentItemType Type;
    }
}
