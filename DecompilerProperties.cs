namespace fastLPI.tools.decompiler
{
    public class DecompilerProperties : IDecompilerProperties
    {
        public bool EscapeUnicodeCharacters = false;
        public bool DisplayLineNumbers = false;
        public bool OutputConsole = false;
        public bool SkipResources = false;
        public bool Version = false;
        public bool Help = false;
        public bool SerialProcessing = false;
        public OutputType OutputType = OutputType.Dir;
        public LogLevel LogLevel = LogLevel.INFO;
        public MethodDictionary Dictionary;

        public DecompilerProperties()
        { 
            this.Dictionary = new MethodDictionary(); 
        }

        public DecompilerProperties(MethodDictionary Dictionary)
        { 
            this.Dictionary = Dictionary; 
        }

        public DecompilerProperties(OutputType OutputType)
        { 
            this.Dictionary = new MethodDictionary(); 
            this.OutputType = OutputType;
        }

        public DecompilerProperties(MethodDictionary Dictionary, OutputType OutputType)
        { 
            this.Dictionary = Dictionary;
            this.OutputType = OutputType;
        }

        public DecompilerProperties(LogLevel LogLevel)
        {
            this.Dictionary = new MethodDictionary();
            this.LogLevel = LogLevel;
        }

        public DecompilerProperties(MethodDictionary Dictionary, LogLevel LogLevel)
        {
            this.Dictionary = Dictionary;
            this.LogLevel = LogLevel;
        }

        public DecompilerProperties(OutputType OutputType, LogLevel LogLevel)
        {
            this.Dictionary = new MethodDictionary();
            this.OutputType = OutputType;
            this.LogLevel = LogLevel;
        }

        public DecompilerProperties(MethodDictionary Dictionary, OutputType OutputType, LogLevel LogLevel)
        {
            this.Dictionary = Dictionary;
            this.OutputType = OutputType;
            this.LogLevel = LogLevel;
        }

        public string CompileDecompilerOptions()
        {
            return (this.Version ? $" {Dictionary.GetVersionOptionCommand()} " : "") +
                   (this.Help ? $" {Dictionary.GetHelpOptionCommand()} " : "") +
                   ($" {Dictionary.GetLogLevelOptionCommand()} " + GetLogLevel(this.LogLevel)) +
                   (this.DisplayLineNumbers ? $" {Dictionary.GetDisplayLineNumbersOptionCommand()} " : "") +
                   (this.EscapeUnicodeCharacters ? $" {Dictionary.GetEscapeUnicodeCharactersOptionCommand()} " : "") +
                   (this.OutputConsole ? $" {Dictionary.GetOutputConsoleOptionCommand()} " : "") +
                   (this.SkipResources ? $" {Dictionary.GetSkipResourcesOptionCommand()} " : "") +
                   (this.SerialProcessing ? $" {Dictionary.GetSerialProcessingOptionCommand()} " : "") +
                   CompileOutputType(this.OutputType, this.Dictionary) +
                   " \"%OUTPATH%\" \"%FILEPATH%\" ";
        }

        public static string CompileOutputType(OutputType OutputType, MethodDictionary Dictionary)
        {
            if (OutputType == OutputType.Dir) return $" {Dictionary.GetOutputDirOptionCommand()} ";
            else if (OutputType == OutputType.Zip) return $" {Dictionary.GetOutputZipFileOptionCommand()} ";
            else return $" {Dictionary.GetOutputDirOptionCommand()} ";
        }

        public static string GetLogLevel(LogLevel level)
        {
            switch (level)
            {
                case LogLevel.ALL: return "ALL";
                case LogLevel.TRACE: return "TRACE";
                case LogLevel.DEBUG: return "DEBUG";
                case LogLevel.INFO: return "INFO";
                case LogLevel.WARN: return "WARN";
                case LogLevel.ERROR: return "ERROR";
                case LogLevel.OFF: return "OFF";
                default: return "INFO";
                    // INFO - Default LogLevel value in jd-cli decompiler https://github.com/intoolswetrust/jd-cli
            }
        }
    }
}
