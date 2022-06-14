namespace fastLPI.tools.decompiler.data
{
    /// <summary>
    /// Access levels in java.
    /// </summary>
    [System.Serializable()]
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
        ProtectedFinalParams = 148,

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
        /// java::final class
        /// </summary>
        FinalClass = 48,

        /// <summary>
        /// java::public final class
        /// </summary>
        PublicFinalClass = 49,

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
        Error,/* = 1025*/

        /// <summary>
        /// java::synchronized
        /// </summary>
        Synchronized = 32,

        /// <summary>
        /// java::static synchronized
        /// </summary>
        StaticSynchronized = 40,

        /// <summary>
        /// java::final synchronized
        /// </summary>
        FinalSynchronized = 48,

        /// <summary>
        /// java::static final synchronized
        /// </summary>
        StaticFinalSynchronized = 56,

        /// <summary>
        /// java::public synchronized
        /// </summary>
        PublicSynchronized = 33,

        /// <summary>
        /// java::public static synchronized
        /// </summary>
        PublicStaticSynchronized = 41,

        /// <summary>
        /// java::private synchronized
        /// </summary>
        PrivateSynchronized = 34,

        /// <summary>
        /// java::private static synchronized
        /// </summary>
        PrivateStaticSynchronized = 42,

        /// <summary>
        /// java::protected synchronized
        /// </summary>
        ProtectedSynchronized = 36,

        /// <summary>
        /// java::protected static synchronized
        /// </summary>
        ProtectedStaticSynchronized = 44,

        /// <summary>
        /// java::public final synchronized
        /// </summary>
        PublicFinalSynchronized = 49,

        /// <summary>
        /// java::public static final synchronized
        /// </summary>
        PublicStaticFinalSynchronized = 57,

        /// <summary>
        /// java::private final synchronized
        /// </summary>
        PrivateFinalSynchronized = 50,

        /// <summary>
        /// java::private static final synchronized
        /// </summary>
        PrivateStaticFinalSynchronized = 58,

        /// <summary>
        /// java::protected final synchronized
        /// </summary>
        ProtectedFinalSynchronized = 52,

        /// <summary>
        /// java::protected static final synchronized
        /// </summary>
        ProtectedStaticFinalSynchronized = 60,

        /// <summary>
        /// java::synchronized params
        /// </summary>
        SynchronizedParams = 160,

        /// <summary>
        /// java::static synchronized params
        /// </summary>
        StaticSynchronizedParams = 168,

        /// <summary>
        /// java::final synchronized params
        /// </summary>
        FinalSynchronizedParams = 176,

        /// <summary>
        /// java::static final synchronized params
        /// </summary>
        StaticFinalSynchronizedParams = 184,

        /// <summary>
        /// java::public synchronized params
        /// </summary>
        PublicSynchronizedParams = 161,

        /// <summary>
        /// java::public static synchronized params
        /// </summary>
        PublicStaticSynchronizedParams = 169,

        /// <summary>
        /// java::private synchronized params
        /// </summary>
        PrivateSynchronizedParams = 162,

        /// <summary>
        /// java::private static synchronized params
        /// </summary>
        PrivateStaticSynchronizedParams = 170,

        /// <summary>
        /// java::protected synchronized params
        /// </summary>
        ProtectedSynchronizedParams = 164,

        /// <summary>
        /// java::protected static synchronized params
        /// </summary>
        ProtectedStaticSynchronizedParams = 172,

        /// <summary>
        /// java::public final synchronized params
        /// </summary>
        PublicFinalSynchronizedParams = 177,

        /// <summary>
        /// java::public static final synchronized params
        /// </summary>
        PublicStaticFinalSynchronizedParams = 185,

        /// <summary>
        /// java::private final synchronized params
        /// </summary>
        PrivateFinalSynchronizedParams = 178,

        /// <summary>
        /// java::private static final synchronized params
        /// </summary>
        PrivateStaticFinalSynchronizedParams = 186,

        /// <summary>
        /// java::protected final synchronized params
        /// </summary>
        ProtectedFinalSynchronizedParams = 180,

        /// <summary>
        /// java::protected static final synchronized params
        /// </summary>
        ProtectedStaticFinalSynchronizedParams = 188,

        /// <summary>
        /// java::deprecated synchronized
        /// </summary>
        DeprecatedSynchronized = 131104,

        /// <summary>
        /// java::static deprecated synchronized
        /// </summary>
        StaticDeprecatedSynchronized = 131112,

        /// <summary>
        /// java::final deprecated synchronized
        /// </summary>
        FinalDeprecatedSynchronized = 131120,

        /// <summary>
        /// java::static final deprecated synchronized
        /// </summary>
        StaticFinalDeprecatedSynchronized = 131128,

        /// <summary>
        /// java::public deprecated synchronized
        /// </summary>
        PublicDeprecatedSynchronized = 131105,

        /// <summary>
        /// java::public static deprecated synchronized
        /// </summary>
        PublicStaticDeprecatedSynchronized = 131113,

        /// <summary>
        /// java::private deprecated synchronized
        /// </summary>
        PrivateDeprecatedSynchronized = 131106,

        /// <summary>
        /// java::private static deprecated synchronized
        /// </summary>
        PrivateStaticDeprecatedSynchronized = 131114,

        /// <summary>
        /// java::protected deprecated synchronized
        /// </summary>
        ProtectedDeprecatedSynchronized = 131108,

        /// <summary>
        /// java::protected static deprecated synchronized
        /// </summary>
        ProtectedStaticDeprecatedSynchronized = 131116,

        /// <summary>
        /// java::public final deprecated synchronized
        /// </summary>
        PublicFinalDeprecatedSynchronized = 131121,

        /// <summary>
        /// java::public static final deprecated synchronized
        /// </summary>
        PublicStaticFinalDeprecatedSynchronized = 131129,

        /// <summary>
        /// java::private final deprecated synchronized
        /// </summary>
        PrivateFinalDeprecatedSynchronized = 131122,

        /// <summary>
        /// java::private static final deprecated synchronized
        /// </summary>
        PrivateStaticFinalDeprecatedSynchronized = 131130,

        /// <summary>
        /// java::protected final deprecated synchronized
        /// </summary>
        ProtectedFinalDeprecatedSynchronized = 131124,

        /// <summary>
        /// java::protected static final deprecated synchronized
        /// </summary>
        ProtectedStaticFinalDeprecatedSynchronized = 131132,

        /// <summary>
        /// java::native synchronized
        /// </summary>
        NativeSynchronized = 288,

        /// <summary>
        /// java::native static synchronized
        /// </summary>
        NativeStaticSynchronized = 264,

        /// <summary>
        /// java::native final synchronized
        /// </summary>
        NativeFinalSynchronized = 272,

        /// <summary>
        /// java::native static final synchronized
        /// </summary>
        NativeStaticFinalSynchronized = 280,

        /// <summary>
        /// java::native public synchronized
        /// </summary>
        NativePublicSynchronized = 257,

        /// <summary>
        /// java::native public static synchronized
        /// </summary>
        NativePublicStaticSynchronized = 265,

        /// <summary>
        /// java::native private synchronized
        /// </summary>
        NativePrivateSynchronized = 258,

        /// <summary>
        /// java::native private static synchronized
        /// </summary>
        NativePrivateStaticSynchronized = 266,

        /// <summary>
        /// java::native protected synchronized
        /// </summary>
        NativeProtectedSynchronized = 260,

        /// <summary>
        /// java::native protected static synchronized
        /// </summary>
        NativeProtectedStaticSynchronized = 268,

        /// <summary>
        /// java::native public final synchronized
        /// </summary>
        NativePublicFinalSynchronized = 273,

        /// <summary>
        /// java::native public static final synchronized
        /// </summary>
        NativePublicStaticFinalSynchronized = 281,

        /// <summary>
        /// java::native private final synchronized
        /// </summary>
        NativePrivateFinalSynchronized = 274,

        /// <summary>
        /// java::native private static final synchronized
        /// </summary>
        NativePrivateStaticFinalSynchronized = 282,

        /// <summary>
        /// java::native protected final synchronized
        /// </summary>
        NativeProtectedFinalSynchronized = 276,

        /// <summary>
        /// java::native protected static final synchronized
        /// </summary>
        NativeProtectedStaticFinalSynchronized = 284,

        /// <summary>
        /// java::native deprecated
        /// </summary>
        NativeDeprecated = 131328,

        /// <summary>
        /// java::native static deprecated
        /// </summary>
        NativeStaticDeprecated = 131336,

        /// <summary>
        /// java::native final deprecated
        /// </summary>
        NativeFinalDeprecated = 131344,

        /// <summary>
        /// java::native static final deprecated
        /// </summary>
        NativeStaticFinalDeprecated = 131352,

        /// <summary>
        /// java::native public deprecated
        /// </summary>
        NativePublicDeprecated = 131329,

        /// <summary>
        /// java::native public static deprecated
        /// </summary>
        NativePublicStaticDeprecated = 131337,

        /// <summary>
        /// java::native private deprecated
        /// </summary>
        NativePrivateDeprecated = 131330,

        /// <summarynative>
        /// java::native private static deprecated
        /// </summary>
        NativePrivateStaticDeprecated = 131338,

        /// <summary>
        /// java::native protected deprecated
        /// </summary>
        NativeProtectedDeprecated = 131332,

        /// <summary>
        /// java::native protected static deprecated
        /// </summary>
        NativeProtectedStaticDeprecated = 131340,

        /// <summary>
        /// java::native public final deprecated
        /// </summary>
        NativePublicFinalDeprecated = 131345,

        /// <summary>
        /// java::native public static final deprecated
        /// </summary>
        NativePublicStaticFinalDeprecated = 131353,

        /// <summary>
        /// java::native private final deprecated
        /// </summary>
        NativePrivateFinalDeprecated = 131346,

        /// <summary>
        /// java::native private static final deprecated
        /// </summary>
        NativePrivateStaticFinalDeprecated = 131354,

        /// <summary>
        /// java::native protected final deprecated
        /// </summary>
        NativeProtectedFinalDeprecated = 131348,

        /// <summary>
        /// java::native protected static final deprecated
        /// </summary>
        NativeProtectedStaticFinalDeprecated = 131356,

        /// <summary>
        /// java::native deprecated synchronized
        /// </summary>
        NativeDeprecatedSynchronized = 131360,

        /// <summary>
        /// java::native static deprecated synchronized
        /// </summary>
        NativeStaticDeprecatedSynchronized = 131368,

        /// <summary>
        /// java::native final deprecated synchronized
        /// </summary>
        NativeFinalDeprecatedSynchronized = 131376,

        /// <summary>
        /// java::native static final deprecated synchronized
        /// </summary>
        NativeStaticFinalDeprecatedSynchronized = 131384,

        /// <summary>
        /// java::native public deprecated synchronized
        /// </summary>
        NativePublicDeprecatedSynchronized = 131361,

        /// <summary>
        /// java::native public static deprecated synchronized
        /// </summary>
        NativePublicStaticDeprecatedSynchronized = 131369,

        /// <summary>
        /// java::native private deprecated synchronized
        /// </summary>
        NativePrivateDeprecatedSynchronized = 131362,

        /// <summary>
        /// java::native private static deprecated synchronized
        /// </summary>
        NativePrivateStaticDeprecatedSynchronized = 131370,

        /// <summary>
        /// java::native protected deprecated synchronized
        /// </summary>
        NativeProtectedDeprecatedSynchronized = 131364,

        /// <summary>
        /// java::native protected static deprecated synchronized
        /// </summary>
        NativeProtectedStaticDeprecatedSynchronized = 131372,

        /// <summary>
        /// java::native public final deprecated synchronized
        /// </summary>
        NativePublicFinalDeprecatedSynchronized = 131377,

        /// <summary>
        /// java::native public static final deprecated synchronized
        /// </summary>
        NativePublicStaticFinalDeprecatedSynchronized = 131385,

        /// <summary>
        /// java::native private final deprecated synchronized
        /// </summary>
        NativePrivateFinalDeprecatedSynchronized = 131378,

        /// <summary>
        /// java::native private static final deprecated synchronized
        /// </summary>
        NativePrivateStaticFinalDeprecatedSynchronized = 131386,

        /// <summary>
        /// java::native protected final deprecated synchronized
        /// </summary>
        NativeProtectedFinalDeprecatedSynchronized = 131380,

        /// <summary>
        /// java::native protected static final deprecated synchronized
        /// </summary>
        NativeProtectedStaticFinalDeprecatedSynchronized = 131388,

        /// <summary>
        /// java::native params
        /// </summary>
        NativeParams = 384,

        /// <summary>
        /// java::native static params
        /// </summary>
        NativeStaticParams = 392,

        /// <summary>
        /// java::native final params
        /// </summary>
        NativeFinalParams = 400,

        /// <summary>
        /// java::native static final params
        /// </summary>
        NativeStaticFinalParams = 408,

        /// <summary>
        /// java::native public params
        /// </summary>
        NativePublicParams = 385,

        /// <summary>
        /// java::native public static params
        /// </summary>
        NativePublicStaticParams = 393,

        /// <summary>
        /// java::native private params
        /// </summary>
        NativePrivateParams = 386,

        /// <summary>
        /// java::native private static params
        /// </summary>
        NativePrivateStaticParams = 394,

        /// <summary>
        /// java::native protected params
        /// </summary>
        NativeProtectedParams = 388,

        /// <summary>
        /// java::native protected static params
        /// </summary>
        NativeProtectedStaticParams = 396,

        /// <summary>
        /// java::native public final params
        /// </summary>
        NativePublicFinalParams = 401,

        /// <summary>
        /// java::native public static final params
        /// </summary>
        NativePublicStaticFinalParams = 409,

        /// <summary>
        /// java::native private final params
        /// </summary>
        NativePrivateFinalParams = 402,

        /// <summary>
        /// java::native private static final params
        /// </summary>
        NativePrivateStaticFinalParams = 410,

        /// <summary>
        /// java::native protected final params
        /// </summary>
        NativeProtectedFinalParams = 404,

        /// <summary>
        /// java::native protected static final params
        /// </summary>
        NativeProtectedStaticFinalParams = 412,

        /// <summary>
        /// java::native synchronized params
        /// </summary>
        NativeSynchronizedParams = 416,

        /// <summary>
        /// java::native static synchronized params
        /// </summary>
        NativeStaticSynchronizedParams = 392,

        /// <summary>
        /// java::native final synchronized params
        /// </summary>
        NativeFinalSynchronizedParams = 400,

        /// <summary>
        /// java::native static final synchronized params
        /// </summary>
        NativeStaticFinalSynchronizedParams = 408,

        /// <summary>
        /// java::native public synchronized params
        /// </summary>
        NativePublicSynchronizedParams = 385,

        /// <summary>
        /// java::native public static synchronized params
        /// </summary>
        NativePublicStaticSynchronizedParams = 393,

        /// <summary>
        /// java::native private synchronized params
        /// </summary>
        NativePrivateSynchronizedParams = 386,

        /// <summary>
        /// java::native private static synchronized params
        /// </summary>
        NativePrivateStaticSynchronizedParams = 394,

        /// <summary>
        /// java::native protected synchronized params
        /// </summary>
        NativeProtectedSynchronizedParams = 388,

        /// <summary>
        /// java::native protected static synchronized params
        /// </summary>
        NativeProtectedStaticSynchronizedParams = 396,

        /// <summary>
        /// java::native public final synchronized params
        /// </summary>
        NativePublicFinalSynchronizedParams = 401,

        /// <summary>
        /// java::native public static final synchronized params
        /// </summary>
        NativePublicStaticFinalSynchronizedParams = 409,

        /// <summary>
        /// java::native private final synchronized params
        /// </summary>
        NativePrivateFinalSynchronizedParams = 402,

        /// <summary>
        /// java::native private static final synchronized params
        /// </summary>
        NativePrivateStaticFinalSynchronizedParams = 410,

        /// <summary>
        /// java::native protected final synchronized params
        /// </summary>
        NativeProtectedFinalSynchronizedParams = 404,

        /// <summary>
        /// java::native protected static final synchronized params
        /// </summary>
        NativeProtectedStaticFinalSynchronizedParams = 412
    }
}
