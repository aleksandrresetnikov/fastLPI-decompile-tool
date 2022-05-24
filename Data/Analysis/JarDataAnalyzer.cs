using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using fastLPI.tools.decompiler.data.digest;

namespace fastLPI.tools.decompiler.data.analysis
{
    public class JarDataAnalyzer
    {
        private protected JarFileDigest Digest;

        public JarDataAnalyzer(JarFileDigest Digest)
        {
            this.Digest = Digest;
        }


    }
}
