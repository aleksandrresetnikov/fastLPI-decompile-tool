namespace fastLPI.tools.decompiler.data
{
    public interface IAccessLevelManager
    {
        void SetAccessLevel(AccessLevelFlags AccessLevel);
        bool IsStatic();
        bool IsFinal();
        bool IsNone();
        bool IsPublic();
        bool IsPrivate();
        bool IsProtected();
        bool IsClass();
        bool IsEnum();
        bool IsInterface();
        bool IsAnnotation();
    }
}
