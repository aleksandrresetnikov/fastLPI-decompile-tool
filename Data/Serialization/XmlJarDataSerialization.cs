using System;
using System.Threading;
using System.IO;
using System.Xml.Serialization;

using fastLPI.tools.decompiler.data.saving;

namespace fastLPI.tools.decompiler.data.serialization
{
    public class XmlJarDataSerialization : IJarDataSerialization
    {
        #region IJarDataSerialization
        public SerializationType GetSerializationType()
        {
            return SerializationType.Json;
        }

        public JarFile Open(string Path)
        {
            using (StreamReader reader = File.OpenText(Path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(JarFile));
                object data = serializer.Deserialize(reader);

                reader.Close();
                GC.Collect();

                return (data as JarFile);
            }
        }

        public void Save(JarDataInstance DataInstance)
        {
            new Thread(() =>
            {
                using (StreamWriter writer = File.CreateText(DataInstance.Properties.OutputDataFileResultPath))
                {
                    XmlSerializer serializer = new XmlSerializer(DataInstance.GetDataType());
                    serializer.Serialize(writer, DataInstance.GetData());

                    writer.Close();
                }

                GC.Collect();
            }).Start();
        }
        #endregion
    }
}
