﻿using System.Collections.Generic;

namespace fastLPI.tools.decompiler.data
{
    public interface IJarFile
    {
        void SetXmlPath(string XmlPath);
        void SetDocumentProperties(JarDocumentLoadingProperties DocumentProperties);
        void SetChildItems(Queue<JarDocumentItem> ChildItems);
        void SetJarDocumentProperties(JarDocumentProperties JarDocumentProperties);
        void SetPackageCollector(PackageCollector PackageCollector);
        digest.PackagesAnalyticDigest GetPackagesAnalyticDigestInstance();
    }
}
