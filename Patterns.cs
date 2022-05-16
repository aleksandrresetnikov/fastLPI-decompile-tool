namespace fastLPI.tools.decompiler.helper
{
    public class Patterns
    {
        internal static readonly string JavaPackagePattern =
            @"package(\s+?|\w+?|\.)*;";

        internal static readonly string JavaClassPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*class(\s+?)*(\w+?)*";

        internal static readonly string JavaClassStartPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*class(\s+?)*";

        internal static readonly string JavaInterfacePattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*interface(\s+?)*(\w+?)*";

        internal static readonly string JavaInterfaceStartPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*interface(\s+?)*";

        internal static readonly string JavaEnumPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*enum(\s+?)*(\w+?)*";

        internal static readonly string JavaEnumStartPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*enum(\s+?)*";
        
        internal static readonly string JavaAccesslevelsPattern =
            @"(private|public final|public abstract|public)";

        internal static readonly string AnyClassPattern =
            @"(private|public final|public abstract|public|\b)(\s+?)*(class|interface|enum)(\s+?|\w+?)*";

        internal static readonly string AnyClassStructurePattern =
            @"{(\s+?|\w+?|\W+?)*}";
    }
}
