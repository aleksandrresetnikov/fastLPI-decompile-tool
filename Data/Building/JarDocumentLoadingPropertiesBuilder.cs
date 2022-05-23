using System;
using System.Xml.Linq;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data.building
{
    public class JarDocumentLoadingPropertiesBuilder
    {
        public static readonly string LpiDataSavingPropertiesItemName = "_____LPI_DATA_SAVING_SAVE_PROPERTIES_____";

        /// <summary>
        /// Xml file.
        /// </summary>
        public XElement XmlFile
        { get; private protected set; }

        /// <summary>
        /// Document properties data when saving.
        /// </summary>
        public XElement DataSavingPropertiesItem
        { get; private protected set; }

        public JarDocumentLoadingPropertiesBuilder(XElement XmlFile)
        {
            try
            {
                this.XmlFile = XmlFile;
                this.DataSavingPropertiesItem = this.XmlFile.GetItemFromName(LpiDataSavingPropertiesItemName);
            }
            catch (Exception ex)
            {
                throw new JarDocumentLoadingPropertiesException(ex.Message);
            }
        }

        public virtual JarDocumentLoadingProperties Build()
        {
            try
            {
                if (this.XmlFile.IsContainName(LpiDataSavingPropertiesItemName))
                {
                    return new JarDocumentLoadingProperties
                    {
                        SaveTime = Convert.ToInt64(DataSavingPropertiesItem.GetItemFromName("SavingTime").Attribute("value").Value),
                        InputPath = DataSavingPropertiesItem.GetItemFromName("InputPath").Attribute("value").Value,
                        OutputPath = DataSavingPropertiesItem.GetItemFromName("OutputPath").Attribute("value").Value,
                        JarFileName = DataSavingPropertiesItem.GetItemFromName("JarFileName").Attribute("value").Value,
                    };
                }
                else
                {
                    throw new JarDocumentLoadingPropertiesException();
                }
            }
            catch (Exception ex)
            {
                throw new JarDocumentLoadingPropertiesException(ex.Message);
            }
        }
    }
}
