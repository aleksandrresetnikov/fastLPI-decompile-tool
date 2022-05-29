using fastLPI.tools.decompiler.data.serialization;

namespace fastLPI.tools.decompiler.data.saving
{
    public class JarDataLoadManager : IJarDataLoadManager
    {
        public string Path
        { get; private protected set; }

        private protected virtual IJarDataSerialization DataSerialization
        { get; set; }

        public JarDataLoadManager(string Path)
        {
            this.Path = Path;
            this.DataSerialization = new BinJarDataSerialization();
        }

        public void SetPath(string Path)
        {
            this.Path = Path;
        }

        public JarFile Load()
        {
            return this.DataSerialization.Open(this.Path);
        }
    }
}
