namespace fastLPI.tools.decompiler
{
    public class MethodDictionary : IMethodDictionary
    {
        //  This class contains a dictionary with decompilation commands and
        //the command of the selected decompiler. Therefore, you can use any
        //decompiler, but you must specify commands for your decompiler.
        //Please create your own class by subclassing this class and provide
        //your decompiler commands. If some command is missing in your decompiler,
        //then set the command to null, an exception
        //(fastLPI.tools.decompiler.NonExistingCommandException)
        //will be thrown when trying to call that command.

        /// <summary>
        /// Displays line numbers in decompiled classes option.
        /// </summary>
        private protected virtual string DisplayLineNumbersOptionCommand { get; }

        /// <summary>
        /// Escape unicode characters in decompiled classes option.
        /// </summary>
        private protected virtual string EscapeUnicodeCharactersOptionCommand { get; }

        /// <summary>
        /// Shows help option.
        /// </summary>
        private protected virtual string HelpOptionCommand { get; }

        /// <summary>
        /// Takes [level] as parameter and sets it as the CLI log level. Possible
        ///values are: ALL, TRACE, DEBUG, INFO, WARN, ERROR, OFF. Option.
        /// </summary>
        private protected virtual string LogLevelOptionCommand { get; }

        /// <summary>
        /// Enables output to system output stream option.
        /// </summary>
        private protected virtual string OutputConsoleOptionCommand { get; }

        /// <summary>
        /// Takes a [directoryPath] as a parameter and configures a flat DIR output for this path option.
        /// </summary>
        private protected virtual string OutputDirOptionCommand { get; }

        /// <summary>
        /// Takes a [directoryPath] as a parameter and configures a structured DIR
        ///output for this path option.
        /// </summary>
        private protected virtual string OutputDirStructuredOptionCommand { get; }

        /// <summary>
        /// Takes a [zipFilePath] as a parameter and configures ZIP output for this path option.
        /// </summary>
        private protected virtual string OutputZipFileOptionCommand { get; }

        /// <summary>
        /// RegExp pattern which the to-be-decompiled file has to match. Not matching
        ///entries are skipped option.
        /// </summary>
        private protected virtual string PatternOptionCommand { get; }

        /// <summary>
        /// Don't use parallel processing option.
        /// </summary>
        private protected virtual string SerialProcessingOptionCommand { get; }

        /// <summary>
        /// Skips processing resources option.
        /// </summary>
        private protected virtual string SkipResourcesOptionCommand { get; }

        /// <summary>
        /// Shows the version option.
        /// </summary>
        private protected virtual string VersionOptionCommand { get; }

        /// <returns>DisplayLineNumbersOptionCommand</returns>
        public virtual string GetDisplayLineNumbersOptionCommand() => 
            throw new NonExistingCommandException();

        /// <returns>EscapeUnicodeCharactersOptionCommand</returns>
        public virtual string GetEscapeUnicodeCharactersOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>HelpOptionCommand</returns>
        public virtual string GetHelpOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>LogLevelOptionCommand</returns>
        public virtual string GetLogLevelOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>OutputConsoleOptionCommand</returns>
        public virtual string GetOutputConsoleOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>OutputDirOptionCommand</returns>
        public virtual string GetOutputDirOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>OutputDirStructuredOptionCommand</returns>
        public virtual string GetOutputDirStructuredOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>OutputZipFileOptionCommand</returns>
        public virtual string GetOutputZipFileOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>PatternOptionCommand</returns>
        public virtual string GetPatternOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>SerialProcessingOptionCommand</returns>
        public virtual string GetSerialProcessingOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>SkipResourcesOptionCommand</returns>
        public virtual string GetSkipResourcesOptionCommand() =>
            throw new NonExistingCommandException();

        /// <returns>VersionOptionCommand</returns>
        public virtual string GetVersionOptionCommand() =>
            throw new NonExistingCommandException();
    }
}
