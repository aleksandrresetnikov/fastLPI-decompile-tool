using System;

using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler.data.saving
{
    public class JarDataInstance : IJarDataInstance, IDisposable
    {
        /// <summary>
        /// Xml document .jar file.
        /// </summary>
        public virtual JarFile Document
        { get; private protected set; }

        /// <summary>
        /// Properties for Jar Data Instance.
        /// </summary>
        public virtual JarDataInstanceProperties Properties
        { get; private protected set; }

        public JarDataInstance(JarFile Document, JarDataInstanceProperties Properties)
        {
            this.Document = Document;
            this.Properties = Properties;
        }

        public JarFile GetDocument()
        {
            return this.Document;
        }

        public JarDataInstanceProperties GetProperties()
        {
            return this.Properties;
        }

        public void Dispose()
        {
            try
            {
                this.Document.Dispose();

                GC.SuppressFinalize((object)this);
                GC.Collect();
            }
            catch (Exception ex)
            {
                Dump.AddDump("JarDataInstance",
                    "\n\n\tJarDataInstance\\Dispose" +
                    "\n\tStackTrace: \n" + ex.StackTrace, true);
            }
        }

        public object GetData()
        {
            return (object)this.Document;
        }

        public Type GetDataType()
        {
            return this.Document.GetType();
        }
    }
}
