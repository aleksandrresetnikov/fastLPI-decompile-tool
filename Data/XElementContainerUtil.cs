using System.Xml.Linq;

namespace fastLPI.tools.decompiler.helper
{
    public static class XElementContainerUtil
    {
        public static bool IsContainName(this XElement XmlElement, string ItemName)
        {
            foreach (XElement item in XmlElement.Elements())
                if (item.Name == ItemName)
                    return true;

            return false;
        }

        public static XElement GetItemFromName(this XElement XmlElement, string ItemName)
        {
            foreach (XElement item in XmlElement.Elements())
                if (item.Name == ItemName)
                    return item;

            return null;
        }
    }
}
