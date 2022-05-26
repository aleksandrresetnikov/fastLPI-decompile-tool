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

        public virtual bool IsStatic() =>
            (this.AccessLevel == AccessLevelFlags.NoneStatic ||
             this.AccessLevel == AccessLevelFlags.NoneStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PrivateStatic ||
             this.AccessLevel == AccessLevelFlags.PrivateStaticFinal ||
             this.AccessLevel == AccessLevelFlags.ProtectedStatic ||
             this.AccessLevel == AccessLevelFlags.ProtectedStaticFinal ||
             this.AccessLevel == AccessLevelFlags.PublicStatic ||
             this.AccessLevel == AccessLevelFlags.PublicStaticFinal);

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
