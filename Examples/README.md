### ✅ An example of decompiling a jar file:
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
</br>

### ✅ Example of using jar file data loading:
```C#
// JarDataLoader does not depend on JD_CLI_JavaDecompiler they can be used separately.

// An instance of the JarDataLoader class.
JarDataLoader dataLoader = new JarDataLoader(PathIn);
dataLoader.Load(); // Loading the xml file with the contents of the jar file (classes, resources, methods, etc...).
dataLoader.LoadJarDataContentFromXmlResult(); // Parsing the xml file and loading data from it.
dataLoader.PrintInfo(); // We output to the console information.
```
#### You can find out all packages in jar file.
```
...C#
// We output to the console all the packages in the jar file.
Console.WriteLine("\nPackages:");
foreach (Package item in dataLoader.Document.PackageCollector)
    Console.WriteLine(item.PackageName);
```
</br>

### ✅ Example of using JarFileDigest:
```C#
// An instance of the JarFileDigest class (to get the total content of elements in one array).
JarFileDigest digest = new JarFileDigest(dataLoader.Document.ChildItems);

// We output to the console all the resources in the jar file.
Console.WriteLine("Resources:");
digest.PrintDigest(JarDocumentItemType.Resource);

// We output to the console all the classses in the jar file.
Console.WriteLine("\nClassses:");
digest.PrintDigest(JarDocumentItemType.Class);

// We output to the console all the methods in the jar file.
Console.WriteLine("\nMethods:");
digest.PrintDigest(JarDocumentItemType.Method);

// We output to the console all the fields in the jar file.
Console.WriteLine("\nFields:");
digest.PrintDigest(JarDocumentItemType.Field);

// We output to the console all the constructors in the jar file.
Console.WriteLine("\nConstructors:");
digest.PrintDigest(JarDocumentItemType.Constructor);
```
</br>

### ✅ You can get a list of all classes in any package of your choice:
```C#
// Let's take any package from the jar file and see its contents (classes).
string packageName = "processing.core.*";

// An instance of the PackagesAnalyticDigest class.
PackagesAnalyticDigest packagesAnalyticDigest = dataLoader.Document.GetPackagesAnalyticDigestInstance();

/*
 *  GetPackageJarDocumentItemsFromImportReference() - 
 *      Returns a set of JarDocumentItems based on the package import context.
 *  
 *  value: javax.swing.JFrame
 *  return: JFrame
 *
 *  value: javax.swing.*
 *  return: { JButton, JFrame, JLabel, JPanel, JScrollPane, JTextArea, JApplet, etc... }
 */
var items = packagesAnalyticDigest.GetPackageJarDocumentItemsFromImportReference(packageName);

Console.WriteLine($"\n{packageName} contains:");
foreach (var item in items)
    Console.WriteLine(item);
```
