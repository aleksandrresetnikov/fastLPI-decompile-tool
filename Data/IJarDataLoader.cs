using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastLPI.tools.decompiler.data
{
    public interface IJarDataLoader
    {
        void Load();
        void SaveXmlResultTo(string path);
    }
}
