namespace fastLPI.tools.decompiler.data
{
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
             this.AccessLevel == AccessLevelFlags.PrivateFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal);

        public bool IsNone() =>
            (this.AccessLevel == AccessLevelFlags.None ||
             this.AccessLevel == AccessLevelFlags.NoneFinal ||
             this.AccessLevel == AccessLevelFlags.NoneStatic ||
             this.AccessLevel == AccessLevelFlags.NoneStaticFinal);

        public bool IsPublic() =>
            (this.AccessLevel == AccessLevelFlags.Public ||
             this.AccessLevel == AccessLevelFlags.PublicFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStatic ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal);

        public bool IsPrivate() =>
            (this.AccessLevel == AccessLevelFlags.Private ||
             this.AccessLevel == AccessLevelFlags.PrivateFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStatic ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal);

        public bool IsProtected() =>
            (this.AccessLevel == AccessLevelFlags.Protected ||
             this.AccessLevel == AccessLevelFlags.ProtectedFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal);
    }
}
