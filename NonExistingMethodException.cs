using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastLPI.tools.decompiler
{
    public class NonExistingMethodException : Exception
    {
        public override string Message => "The method is missing in this decompiler.";
    }
}
