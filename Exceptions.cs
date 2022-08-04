using System;

namespace fastLPI.tools.decompiler.helper
{
    public class CouldNotFindTheEndOfTheParenthesisLevelException : Exception
    {
        public CouldNotFindTheEndOfTheParenthesisLevelException() : base("Could not find the end of the parenthesis level.")
        { }
    }

    public class NonExistingMethodException : Exception
    {
        public NonExistingMethodException() : base("The method is missing in this decompiler.")
        { }
    }

    public class NonExistingCommandException : Exception
    {
        public NonExistingCommandException() : base("The command is missing in this decompiler.")
        { }
    }
}
