using System;
using System.Threading;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using fastLPI.tools.decompiler.data.saving;

namespace fastLPI.tools.decompiler.data.serialization
{
    public class BinJarDataSerialization : IJarDataSerialization
    {
        #region IJarDataSerialization
        public SerializationType GetSerializationType()
        {
            return SerializationType.Bin;
        }

        public JarFile Open(string Path)
        {
            if (!File.Exists(Path)) throw new FileNotFoundException();

            using (Stream stream = new FileStream(Path, FileMode.Open))
            {
                IFormatter formatter = new BinaryFormatter();
                object data = formatter.Deserialize(stream);

                stream.Close();
                GC.Collect();

                return (data as JarFile);
            }
        }

        public void Save(JarDataInstance DataInstance)
        {
            CheckCasheDataDir(new FileInfo(DataInstance.Properties.OutputDataFileResultPath).Directory.FullName);

            //new Thread(() => {
                using (Stream stream = new FileStream(DataInstance.Properties.OutputDataFileResultPath, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(stream, DataInstance.GetData());

                    stream.Close();
                }

                GC.Collect();
            //}).Start();
        }
        #endregion

        private static void CheckCasheDataDir(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
