using System;

namespace fastLPI.tools.decompiler
{
    public class NonExistingCommandException : Exception
    {
        public override string Message => "The command is missing in this decompiler.";
    }
}
