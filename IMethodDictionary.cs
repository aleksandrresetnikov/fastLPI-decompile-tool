using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastLPI.tools.decompiler
{
    public interface IMethodDictionary 
    {
        string GetDisplayLineNumbersOptionCommand();
        string GetEscapeUnicodeCharactersOptionCommand();
        string GetHelpOptionCommand();
        string GetLogLevelOptionCommand();
        string GetOutputConsoleOptionCommand();
        string GetOutputDirOptionCommand();
        string GetOutputDirStructuredOptionCommand();
        string GetOutputZipFileOptionCommand();
        string GetPatternOptionCommand();
        string GetSerialProcessingOptionCommand();
        string GetSkipResourcesOptionCommand();
        string GetVersionOptionCommand();
    }
}
