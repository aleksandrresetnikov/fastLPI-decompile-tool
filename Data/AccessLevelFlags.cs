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
        /// java::
        /// </summary>
        NoneSynchronized = 32,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticSynchronized = 40,

        /// <summary>
        /// java::
        /// </summary>
        NoneFinalSynchronized = 48,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticFinalSynchronized = 56,

        /// <summary>
        /// java::
        /// </summary>
        PublicSynchronized = 33,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticSynchronized = 41,

        /// <summary>
        /// java::
        /// </summary>
        PrivateSynchronized = 34,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticSynchronized = 42,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedSynchronized = 36,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticSynchronized = 44,

        /// <summary>
        /// java::
        /// </summary>
        PublicFinalSynchronized = 49,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticFinalSynchronized = 57,

        /// <summary>
        /// java::
        /// </summary>
        PrivateFinalSynchronized = 50,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticFinalSynchronized = 58,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedFinalSynchronized = 52,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticFinalSynchronized = 60,

        /// <summary>
        /// java::
        /// </summary>
        NoneSynchronizedParams = 160,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticSynchronizedParams = 168,

        /// <summary>
        /// java::
        /// </summary>
        NoneFinalSynchronizedParams = 176,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticFinalSynchronizedParams = 184,

        /// <summary>
        /// java::
        /// </summary>
        PublicSynchronizedParams = 161,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticSynchronizedParams = 169,

        /// <summary>
        /// java::
        /// </summary>
        PrivateSynchronizedParams = 162,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticSynchronizedParams = 170,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedSynchronizedParams = 164,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticSynchronizedParams = 172,

        /// <summary>
        /// java::
        /// </summary>
        PublicFinalSynchronizedParams = 177,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticFinalSynchronizedParams = 185,

        /// <summary>
        /// java::
        /// </summary>
        PrivateFinalSynchronizedParams = 178,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticFinalSynchronizedParams = 186,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedFinalSynchronizedParams = 180,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticFinalSynchronizedParams = 188,

        /// <summary>
        /// java::
        /// </summary>
        NoneDeprecatedSynchronized = 131104,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticDeprecatedSynchronized = 131112,

        /// <summary>
        /// java::
        /// </summary>
        NoneFinalDeprecatedSynchronized = 131120,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticFinalDeprecatedSynchronized = 131128,

        /// <summary>
        /// java::
        /// </summary>
        PublicDeprecatedSynchronized = 131105,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticDeprecatedSynchronized = 131113,

        /// <summary>
        /// java::
        /// </summary>
        PrivateDeprecatedSynchronized = 131106,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticDeprecatedSynchronized = 131114,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedDeprecatedSynchronized = 131108,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticDeprecatedSynchronized = 131116,

        /// <summary>
        /// java::
        /// </summary>
        PublicFinalDeprecatedSynchronized = 131121,

        /// <summary>
        /// java::
        /// </summary>
        PublicStaticFinalDeprecatedSynchronized = 131129,

        /// <summary>
        /// java::
        /// </summary>
        PrivateFinalDeprecatedSynchronized = 131122,

        /// <summary>
        /// java::
        /// </summary>
        PrivateStaticFinalDeprecatedSynchronized = 131130,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedFinalDeprecatedSynchronized = 131124,

        /// <summary>
        /// java::
        /// </summary>
        ProtectedStaticFinalDeprecatedSynchronized = 131132,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneSynchronized = 288,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticSynchronized = 264,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneFinalSynchronized = 272,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticFinalSynchronized = 280,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicSynchronized = 257,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticSynchronized = 265,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateSynchronized = 258,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticSynchronized = 266,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedSynchronized = 260,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticSynchronized = 268,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicFinalSynchronized = 273,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticFinalSynchronized = 281,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateFinalSynchronized = 274,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticFinalSynchronized = 282,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedFinalSynchronized = 276,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticFinalSynchronized = 284,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneDeprecated = 131328,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticDeprecated = 131336,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneFinalDeprecated = 131344,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticFinalDeprecated = 131352,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicDeprecated = 131329,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticDeprecated = 131337,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateDeprecated = 131330,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticDeprecated = 131338,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedDeprecated = 131332,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticDeprecated = 131340,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicFinalDeprecated = 131345,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticFinalDeprecated = 131353,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateFinalDeprecated = 131346,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticFinalDeprecated = 131354,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedFinalDeprecated = 131348,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticFinalDeprecated = 131356,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneDeprecatedSynchronized = 131360,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticDeprecatedSynchronized = 131368,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneFinalDeprecatedSynchronized = 131376,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticFinalDeprecatedSynchronized = 131384,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicDeprecatedSynchronized = 131361,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticDeprecatedSynchronized = 131369,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateDeprecatedSynchronized = 131362,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticDeprecatedSynchronized = 131370,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedDeprecatedSynchronized = 131364,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticDeprecatedSynchronized = 131372,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicFinalDeprecatedSynchronized = 131377,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticFinalDeprecatedSynchronized = 131385,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateFinalDeprecatedSynchronized = 131378,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticFinalDeprecatedSynchronized = 131386,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedFinalDeprecatedSynchronized = 131380,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticFinalDeprecatedSynchronized = 131388,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneParams = 384,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticParams = 392,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneFinalParams = 400,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticFinalParams = 408,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicParams = 385,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticParams = 393,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateParams = 386,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticParams = 394,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedParams = 388,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticParams = 396,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicFinalParams = 401,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticFinalParams = 409,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateFinalParams = 402,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticFinalParams = 410,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedFinalParams = 404,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticFinalParams = 412,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneSynchronizedParams = 416,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticSynchronizedParams = 392,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneFinalSynchronizedParams = 400,

        /// <summary>
        /// java::
        /// </summary>
        NativeNoneStaticFinalSynchronizedParams = 408,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicSynchronizedParams = 385,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticSynchronizedParams = 393,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateSynchronizedParams = 386,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticSynchronizedParams = 394,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedSynchronizedParams = 388,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticSynchronizedParams = 396,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicFinalSynchronizedParams = 401,

        /// <summary>
        /// java::
        /// </summary>
        NativePublicStaticFinalSynchronizedParams = 409,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateFinalSynchronizedParams = 402,

        /// <summary>
        /// java::
        /// </summary>
        NativePrivateStaticFinalSynchronizedParams = 410,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedFinalSynchronizedParams = 404,

        /// <summary>
        /// java::
        /// </summary>
        NativeProtectedStaticFinalSynchronizedParams = 412,

        /// <summary>
        /// java::
        /// </summary>
        NoneDeprecated = 131200,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticDeprecated = 131208,

        /// <summary>
        /// java::
        /// </summary>
        NoneFinalDeprecated = 131216,

        /// <summary>
        /// java::
        /// </summary>
        NoneStaticFinalDeprecated = 131224
    }
}
