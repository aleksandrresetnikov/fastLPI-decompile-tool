using System;

using fastLPI.tools.decompiler.data.saving;
using fastLPI.tools.decompiler.data.serialization;

namespace fastLPI.tools.decompiler.data
{
    public class JarDataSavingManager
    {
        public virtual JarDataInstance DataInstance
        { get; set; }

        private protected virtual IJarDataSerialization DataSerialization
        { get; set; }

        public JarDataSavingManager(JarDataInstance DataInstance)
        {
            this.DataInstance = DataInstance;
            this.DataSerialization = new BinJarDataSerialization();
        }

        public void Save()
        {
            Console.WriteLine("FilePath=" + this.DataInstance.Properties.FilePath);
            Console.WriteLine("OutputDataFileResultPath=" + this.DataInstance.Properties.OutputDataFileResultPath);
            Console.WriteLine("OutputXmlFileResultPath=" + this.DataInstance.Properties.OutputXmlFileResultPath);

            DataSerialization.Save(this.DataInstance);
        }
    }
}
