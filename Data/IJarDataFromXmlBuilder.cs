using System.Xml.Linq;

namespace fastLPI.tools.decompiler.data
{
    public interface IJarDataFromXmlBuilder
    {
        void SetXmlPath(string XmlPath);
        XElement GetXmlFile();
        JarFile BuildDocument();
    }
}
