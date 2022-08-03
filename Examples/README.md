### An example of decompiling a jar file:
```C#
 // An instance of the JD_CLI_JavaDecompiler class.
JD_CLI_JavaDecompiler decompiler = new JD_CLI_JavaDecompiler(PathIn, PathTo);
decompiler.Properties.SkipResources = false; // SkipResources - whether the decompiler will skip resources when decompiling.
decompiler.Properties.DisplayLineNumbers = false; // DisplayLineNumbers - whether the decompiler will print the line numbers in the compiled code.
decompiler.Properties.OutputType = OutputType.Dir; // OutputType - output code type (Dir or Zip).
decompiler.Properties.LogLevel = LogLevel.INFO; // LogLevel - decompiler log level during decompilation.
decompiler.CreateNoWindow = false;
decompiler.Decompile(true); // decompile...
```

#### You can display the result of the decompiler execution (logs).
```C#
...
// Output to the console decompiler logs.
Console.WriteLine(decompiler.DecompilerProcessReaderOutputData);
```
