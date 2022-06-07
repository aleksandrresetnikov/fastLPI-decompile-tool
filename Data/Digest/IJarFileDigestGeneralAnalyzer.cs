using System.Collections.Generic;

using fastLPI.tools.decompiler.data;

namespace fastLPI.tools.decompiler.data.digest
{
    public interface IJarFileDigestGeneralAnalyzer
    {
        Queue<JarDocumentItem> GetClasses();
        Queue<JarDocumentItem> GetMethods();
        Queue<JarDocumentItem> GetClassFiles();
        Queue<JarDocumentItem> GetConstructors();
        Queue<JarDocumentItem> GetFields();
        Queue<JarDocumentItem> GetPackageItems();
    }
}
