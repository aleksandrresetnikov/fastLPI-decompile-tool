using fastLPI.tools.decompiler.data.saving;

namespace fastLPI.tools.decompiler.data.serialization
{
    public interface IJarDataSerialization
    {
        SerializationType GetSerializationType();
        void Save(JarDataInstance DataInstance);
        JarFile Open(string Path);
    }
}
