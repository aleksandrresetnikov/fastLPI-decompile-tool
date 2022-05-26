namespace fastLPI.tools.decompiler.data
{
    /// <summary>
    /// Access levels in java.
    /// </summary>
    public enum AccessLevelFlags
    {
        /// <summary>
        /// java::no access level
        /// </summary>
        None = 0,

        /// <summary>
        /// java::static
        /// </summary>
        NoneStatic = 8,

        /// <summary>
        /// java::final
        /// </summary>
        NoneFinal = 16,

        /// <summary>
        /// java::static final
        /// </summary>
        NoneStaticFinal = 24,

        /// <summary>
        /// java::public
        /// </summary>
        Public = 1,

        /// <summary>
        /// java::public static
        /// </summary>
        PublicStatic = 9,

        /// <summary>
        /// java::private
        /// </summary>
        Private = 2,

        /// <summary>
        /// java::private static
        /// </summary>
        PrivateStatic = 10,

        /// <summary>
        /// java::protected
        /// </summary>
        Protected = 4,

        /// <summary>
        /// java::protected static
        /// </summary>
        ProtectedStatic = 12,

        /// <summary>
        /// java::public
        /// </summary>
        PublicFinal = 17,

        /// <summary>
        /// java::public static final
        /// </summary>
        PublicStaticFinal = 25,

        /// <summary>
        /// java::private final
        /// </summary>
        PrivateFinal = 18,

        /// <summary>
        /// java::private static final
        /// </summary>
        PrivateStaticFinal = 26,

        /// <summary>
        /// java::protected final
        /// </summary>
        ProtectedFinal = 20,

        /// <summary>
        /// java::protected static final
        /// </summary>
        ProtectedStaticFinal = 28,

        /// <summary>
        /// java::interface item
        /// </summary>
        InInterface = 1025,

        /// <summary>
        /// java::abstract
        /// </summary>
        Abstract = 1024,

        /// <summary>
        /// java::public abstract
        /// </summary>
        PublicAbstract = 1025,

        /// <summary>
        /// java::protected abstract
        /// </summary>
        ProtectedAbstract = 1028,

        /// <summary>
        /// java::params
        /// </summary>
        Params = 128,

        /// <summary>
        /// java::static params 
        /// </summary>
        StaticParams = 136,

        /// <summary>
        /// java::final params 
        /// </summary>
        FinalParams = 144,

        /// <summary>
        /// java::static final params 
        /// </summary>
        StaticFinalParams = 152,

        /// <summary>
        /// java::public params 
        /// </summary>
        PublicParams = 129,

        /// <summary>
        /// java::public static params 
        /// </summary>
        PublicStaticParams = 137,

        /// <summary>
        /// java::private params 
        /// </summary>
        PrivateParams = 130,

        /// <summary>
        /// java::private static params 
        /// </summary>
        PrivateStaticParams = 138,

        /// <summary>
        /// java::protected params 
        /// </summary>
        ProtectedParams = 132,

        /// <summary>
        /// java::protected static params
        /// </summary>
        ProtectedStaticParams = 140,

        /// <summary>
        /// java::public final params
        /// </summary>
        PublicFinalParams = 145,

        /// <summary>
        /// java::public static final params
        /// </summary>
        PublicStaticFinalParams = 153,

        /// <summary>
        /// java::private final params
        /// </summary>
        PrivateFinalParams = 146,

        /// <summary>
        /// java::private static final params
        /// </summary>
        PrivateStaticFinalParams = 154,

        /// <summary>
        /// java::protected fina params
        /// </summary>
        ProtectedFinaParams = 148,

        /// <summary>
        /// java::protected static final params
        /// </summary>
        ProtectedStaticFinalParams = 156,

        /// <summary>
        /// java::deprecated
        /// </summary>
        Deprecated = 131072,

        /// <summary>
        /// java::static deprecated
        /// </summary>
        StaticDeprecated = 131080,

        /// <summary>
        /// java::final deprecated
        /// </summary>
        FinalDeprecated = 131088,

        /// <summary>
        /// java::static final deprecated
        /// </summary>
        StaticFinalDeprecated = 131096,

        /// <summary>
        /// java::public deprecated
        /// </summary>
        PublicDeprecated = 131073,

        /// <summary>
        /// java::public static deprecated
        /// </summary>
        PublicStaticDeprecated = 131081,

        /// <summary>
        /// java::private deprecated
        /// </summary>
        PrivateDeprecated = 131074,

        /// <summary>
        /// java::private static deprecated
        /// </summary>
        PrivateStaticDeprecated = 131082,

        /// <summary>
        /// java::protected deprecated
        /// </summary>
        ProtectedDeprecated = 131076,

        /// <summary>
        /// java::protected static deprecated
        /// </summary>
        ProtectedStaticDeprecated = 131084,

        /// <summary>
        /// java::public final deprecated
        /// </summary>
        PublicFinalDeprecated = 131089,

        /// <summary>
        /// java::public static final deprecated
        /// </summary>
        PublicStaticFinalDeprecated = 131097,

        /// <summary>
        /// java::private final deprecated
        /// </summary>
        PrivateFinalDeprecated = 131090,

        /// <summary>
        /// java::private static final deprecated
        /// </summary>
        PrivateStaticFinalDeprecated = 131098,

        /// <summary>
        /// java::protected final deprecated
        /// </summary>
        ProtectedFinalDeprecated = 131092,

        /// <summary>
        /// java::protected static final deprecated
        /// </summary>
        ProtectedStaticFinalDeprecated = 131100,

        /// <summary>
        /// java::native
        /// </summary>
        Native = 256,

        /// <summary>
        /// java::native static
        /// </summary>
        NativeStatic = 264,

        /// <summary>
        /// java::native final
        /// </summary>
        NativeFinal = 272,

        /// <summary>
        /// java::native static final
        /// </summary>
        NativeStaticFinal = 280,

        /// <summary>
        /// java::native public
        /// </summary>
        NativePublic = 257,

        /// <summary>
        /// java::native public static
        /// </summary>
        NativePublicStatic = 265,

        /// <summary>
        /// java::native private
        /// </summary>
        NativePrivate = 258,

        /// <summary>
        /// java::native private static
        /// </summary>
        NativePrivateStatic = 266,

        /// <summary>
        /// java::native protected
        /// </summary>
        NativeProtected = 260,

        /// <summary>
        /// java::native protected static
        /// </summary>
        NativeProtectedStatic = 268,

        /// <summary>
        /// java::native public final
        /// </summary>
        NativePublicFinal = 273,

        /// <summary>
        /// java::native public static final
        /// </summary>
        NativePublicStaticFinal = 281,

        /// <summary>
        /// java::native private final
        /// </summary>
        NativePrivateFinal = 274,

        /// <summary>
        /// java::native private static final
        /// </summary>
        NativePrivateStaticFinal = 282,

        /// <summary>
        /// java::native protected final
        /// </summary>
        NativeProtectedFinal = 276,

        /// <summary>
        /// java::native protected static final
        /// </summary>
        NativeProtectedStaticFinal = 284,

        /// <summary>
        /// java::abstract class
        /// </summary>
        AbstractClass = 1056,

        /// <summary>
        /// java::public abstract class
        /// </summary>
        PublicAbstractClass = 1057,

        /// <summary>
        /// java::annotation
        /// </summary>
        Annotation = 9728,

        /// <summary>
        /// java::public annotation
        /// </summary>
        PublicAnnotation = 9729,

        /// <summary>
        /// java::class
        /// </summary>
        Class = 32,

        /// <summary>
        /// java::public class
        /// </summary>
        PublicClass = 33,

        /// <summary>
        /// java::enum
        /// </summary>
        Enum = 16432,

        /// <summary>
        /// java::public enum
        /// </summary>
        PublicEnum = 16433,

        /// <summary>
        /// java::interface
        /// </summary>
        Interface = 1536,

        /// <summary>
        /// java::public interface
        /// </summary>
        PublicInterface = 1537,

        /// <summary>
        /// Error !
        /// </summary>
        Error = 1025
    }
}
