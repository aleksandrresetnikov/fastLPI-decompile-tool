namespace fastLPI.tools.decompiler
{
    /// <summary>
    /// https://github.com/intoolswetrust/jd-cli/blob/master/README.md - jd-cli
    /// </summary>
    public class JD_CLI_Dictionary : MethodDictionary
    {
        private protected override string DisplayLineNumbersOptionCommand
        { get => "-n"; }

        private protected override string EscapeUnicodeCharactersOptionCommand
        { get => "-eu"; }

        private protected override string HelpOptionCommand
        { get => "-h"; }

        private protected override string LogLevelOptionCommand
        { get => "-g"; }

        private protected override string OutputConsoleOptionCommand
        { get => "-oc"; }

        private protected override string OutputDirOptionCommand
        { get => "-od"; }

        private protected override string OutputDirStructuredOptionCommand
        { get => "-ods"; }

        private protected override string OutputZipFileOptionCommand
        { get => "-oz"; }

        private protected override string PatternOptionCommand
        { get => "-p"; }

        private protected override string SerialProcessingOptionCommand
        { get => "-sp"; }

        private protected override string SkipResourcesOptionCommand
        { get => "-sr"; }

        private protected override string VersionOptionCommand
        { get => "-v"; }

        public override string GetDisplayLineNumbersOptionCommand() =>
            this.DisplayLineNumbersOptionCommand;

        public override string GetEscapeUnicodeCharactersOptionCommand() =>
            this.EscapeUnicodeCharactersOptionCommand;

        public override string GetHelpOptionCommand() =>
            this.HelpOptionCommand;

        public override string GetLogLevelOptionCommand() =>
            this.LogLevelOptionCommand;

        public override string GetOutputConsoleOptionCommand() =>
            this.OutputConsoleOptionCommand;

        public override string GetOutputDirOptionCommand() =>
            this.OutputDirOptionCommand;

        public override string GetOutputDirStructuredOptionCommand() =>
            this.OutputDirStructuredOptionCommand;

        public override string GetOutputZipFileOptionCommand() =>
            this.OutputZipFileOptionCommand;

        public override string GetPatternOptionCommand() =>
            this.PatternOptionCommand;

        public override string GetSerialProcessingOptionCommand() =>
            this.SerialProcessingOptionCommand;

        public override string GetSkipResourcesOptionCommand() =>
            this.SkipResourcesOptionCommand;

        public override string GetVersionOptionCommand() =>
            this.VersionOptionCommand;
    }
}
