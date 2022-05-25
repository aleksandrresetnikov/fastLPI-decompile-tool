using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastLPI.tools.decompiler.data
{
    public class Patterns
    {
        public static readonly string MethodPattern =
            @"\([^\(|^\)]*\)(\s+?)*\:(\s+?)*(\w+?|\[+?|\]+?|\<+?|\>+?)*";

        public static readonly string FieldPattern =
            @"(\s+?)*\:(\s+?)*(\w+?|\[+?|\]+?|\<+?|\>+?)*";

        public static readonly string ConstructorPattern =
            @"(\w+?)*\([^\(|^\)]*\)";
    }
}
