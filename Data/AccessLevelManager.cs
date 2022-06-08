namespace fastLPI.tools.decompiler.data
{
    [System.Serializable]
    public class AccessLevelManager : IAccessLevelManager
    {
        public virtual AccessLevelFlags AccessLevel
        { get; private protected set; }

        public AccessLevelManager(AccessLevelFlags AccessLevel)
        {
            this.AccessLevel = AccessLevel;
        }

        public void SetAccessLevel(AccessLevelFlags AccessLevel)
        {
            this.AccessLevel = AccessLevel;
        }

        public virtual bool IsStatic() => //32
            (this.AccessLevel == AccessLevelFlags.NoneStatic ||
             this.AccessLevel == AccessLevelFlags.NoneStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStatic ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStatic ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.StaticParams  ||
             this.AccessLevel == AccessLevelFlags.StaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PublicStaticParams ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticParams ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.StaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.StaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.NativeStatic ||
             this.AccessLevel == AccessLevelFlags.NativeStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativePublicStatic ||
             this.AccessLevel == AccessLevelFlags.NativePrivateStatic ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.NativePublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativePrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedStaticFinal);

        public bool IsFinal() =>
            (this.AccessLevel == AccessLevelFlags.NoneFinal ||
             this.AccessLevel == AccessLevelFlags.NoneStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.FinalParams ||
             this.AccessLevel == AccessLevelFlags.StaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PublicFinalParams ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PrivateFinalParams ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinalParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.FinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.StaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.NativeFinal ||
             this.AccessLevel == AccessLevelFlags.NativeStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativePublicFinal ||
             this.AccessLevel == AccessLevelFlags.NativePublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativePrivateFinal ||
             this.AccessLevel == AccessLevelFlags.NativePrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicFinalClass ||
             this.AccessLevel == AccessLevelFlags.FinalClass);

        public bool IsNone() =>
            (this.AccessLevel == AccessLevelFlags.None ||
             this.AccessLevel == AccessLevelFlags.NoneStatic ||
             this.AccessLevel == AccessLevelFlags.NoneFinal ||
             this.AccessLevel == AccessLevelFlags.NoneStaticFinal ||
             this.AccessLevel == AccessLevelFlags.Params ||
             this.AccessLevel == AccessLevelFlags.StaticParams ||
             this.AccessLevel == AccessLevelFlags.FinalParams ||
             this.AccessLevel == AccessLevelFlags.StaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.Deprecated ||
             this.AccessLevel == AccessLevelFlags.StaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.FinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.StaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.Native ||
             this.AccessLevel == AccessLevelFlags.NativeStatic ||
             this.AccessLevel == AccessLevelFlags.NativeFinal ||
             this.AccessLevel == AccessLevelFlags.NativeStaticFinal);

        public bool IsPublic() =>
            (this.AccessLevel == AccessLevelFlags.Public ||
             this.AccessLevel == AccessLevelFlags.PublicStatic ||
             this.AccessLevel == AccessLevelFlags.PublicFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicAbstract ||
             this.AccessLevel == AccessLevelFlags.PublicParams ||
             this.AccessLevel == AccessLevelFlags.PublicStaticParams ||
             this.AccessLevel == AccessLevelFlags.PublicFinalParams ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PublicDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.NativePublic ||
             this.AccessLevel == AccessLevelFlags.NativePublicStatic ||
             this.AccessLevel == AccessLevelFlags.NativePublicFinal ||
             this.AccessLevel == AccessLevelFlags.NativePublicStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicAbstractClass ||
             this.AccessLevel == AccessLevelFlags.PublicAnnotation ||
             this.AccessLevel == AccessLevelFlags.PublicClass ||
             this.AccessLevel == AccessLevelFlags.PublicEnum ||
             this.AccessLevel == AccessLevelFlags.PublicInterface ||
             this.AccessLevel == AccessLevelFlags.PublicFinalClass);

        public bool IsPrivate() =>
            (this.AccessLevel == AccessLevelFlags.Private ||
             this.AccessLevel == AccessLevelFlags.PrivateStatic ||
             this.AccessLevel == AccessLevelFlags.PrivateFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateParams ||
             this.AccessLevel == AccessLevelFlags.PrivateStatic ||
             this.AccessLevel == AccessLevelFlags.PrivateFinalParams ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.PrivateDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.NativePrivate ||
             this.AccessLevel == AccessLevelFlags.NativePrivateStatic ||
             this.AccessLevel == AccessLevelFlags.NativePrivateFinal ||
             this.AccessLevel == AccessLevelFlags.NativePrivateStaticFinal);

        public bool IsProtected() =>
            (this.AccessLevel == AccessLevelFlags.Protected ||
             this.AccessLevel == AccessLevelFlags.ProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedAbstract ||
             this.AccessLevel == AccessLevelFlags.ProtectedParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinalParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalParams ||
             this.AccessLevel == AccessLevelFlags.ProtectedDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinalDeprecated ||
             this.AccessLevel == AccessLevelFlags.NativeProtected ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.NativeProtectedStaticFinal);

        public bool IsClass() =>
            (this.AccessLevel == AccessLevelFlags.AbstractClass ||
             this.AccessLevel == AccessLevelFlags.PublicAbstractClass ||
             this.AccessLevel == AccessLevelFlags.Class ||
             this.AccessLevel == AccessLevelFlags.PublicClass ||
             this.AccessLevel == AccessLevelFlags.PublicFinalClass ||
             this.AccessLevel == AccessLevelFlags.FinalClass);

        public bool IsEnum() =>
            (this.AccessLevel == AccessLevelFlags.Enum ||
             this.AccessLevel == AccessLevelFlags.PublicEnum);

        public bool IsInterface() =>
            (this.AccessLevel == AccessLevelFlags.Interface ||
             this.AccessLevel == AccessLevelFlags.PublicInterface);

        public bool IsAnnotation() =>
            (this.AccessLevel == AccessLevelFlags.Annotation ||
             this.AccessLevel == AccessLevelFlags.PublicAnnotation);
    }
}
