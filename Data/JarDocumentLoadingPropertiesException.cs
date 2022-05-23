using System;
using System.Runtime.Serialization;

namespace fastLPI.tools.decompiler.data
{
    public class JarDocumentLoadingPropertiesException : Exception
    {
        public override string Message => "Error constructing a new instance of the JarDocumentLoadingProperties class.";

        public JarDocumentLoadingPropertiesException() :
            base()
        { }

        public JarDocumentLoadingPropertiesException(string message) :
            base(message)
        { }

        public JarDocumentLoadingPropertiesException(string message, Exception innerException) :
            base(message, innerException)
        { }

        protected JarDocumentLoadingPropertiesException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        { }
    }
}
