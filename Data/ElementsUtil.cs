using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;

namespace fastLPI.tools.decompiler.helper
{
    public static class ElementsUtil
    {
        public static Dictionary<char, char> SynonymousSymbols { get; } =
            new Dictionary<char, char>{
            { 'ъ', ' ' },
            { 'й', ',' },
            { 'Ѣ', '(' },
            { 'Ѡ', ')' },
            { 'Ѵ', '[' },
            { 'Ѳ', ']' },
            { 'Ѥ', ':' }
        };

        public static string RecognizeItemContext(this string ElementName)
        {
            string outValue = ElementName;

            foreach (char DictionaryItem in SynonymousSymbols.Keys)
                outValue = outValue.Replace(DictionaryItem, SynonymousSymbols[DictionaryItem]);

            return outValue;
        }

        public static string GetItemContextFromPath(this string ElementPath)
        {
            string[] PartsFromThePath = ElementPath.Split('\\');

            return PartsFromThePath[PartsFromThePath.Length - 1];
        }

        public static int GetDocumentItemsLength(this XElement XmlElement)
        {
            return XmlElement.Elements().Count();
        }

        public static int GetDocumentItemsFullLength(this XElement XmlElement)
        {
            int outValue = XmlElement.GetDocumentItemsLength();

            foreach (XElement item in XmlElement.Elements())
                outValue += item.GetDocumentItemsFullLength();

            return outValue;
        }
    }
}
