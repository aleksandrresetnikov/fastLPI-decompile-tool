# fastLPI-decompile-tool
A tool for C# that allows you to connect, configure and conveniently use any decompiler.

## ✅Inspiration and needs.
I was making my own Java code editor in C#, I needed to know what packages, classes, methods are in Jar libraries (Jar files that the user imports) for further code hinting and syntax highlighting.

## ✅Decision.
I found a very handy <a href="https://github.com/intoolswetrust/jd-cli">jd-cli utility</a>, which was a branch of the <a href="https://github.com/java-decompiler/jd-core">JD-Core project</a>. It was decided to develop a C # Api, to which any decompiler could be connected. In this case, the input commands and parameters of the decompilers may differ, so you can specify your command dictionary, as well as add your own.

### For example :
The jd-cli decompiler has an outputZipFile command that takes the value of the output zip path, and in the dictionary this command will be given as "-oz".

## ✅Usage the code analysis: 
### <a href="https://github.com/aleksandrresetnikov/fastLPI-decompile-tool/blob/main/Files/jd-gui-forLPI/jd-gui-forLPI.jar">Here are the code analysis files</a> for fastLPI-decompile-tool-example (based on <a href="https://github.com/java-decompiler/jd-gui">jd-gui</a>).

Usage: <strong>jd-gui-forLPI </strong>\<path to jar file\> - Next to the selected jar file (in the same folder) an xml document will be created with the contents of this jar file (classes, fields, motods and their access level). Next, you can connect the fastLPI-decompile-tool library to your C Sharp project, and use it to find out the entire contents of the jar, as well as the access level of classes, motods, fields, etc. You can also find interfaces, enumerations, etc.

#### You can download the jd-gui-forLPI source <a href="https://github.com/aleksandrresetnikov/fastLPI-decompile-tool/blob/main/Files/jd-gui-forLPI/source%20code.zip">here</a>.
#### You can use the <a href="https://github.com/flyingmessages/fastLPI-decompile-tool-example">excellent example</a> using fastLPI-decompile-tool.

For more examples and help just email me (aleksandrresetnikov093@gmail.com).

## ✅Help in development:
At the moment I am working on this project alone from two accounts (the second account is needed to create a fork with an example). At the moment there are a large number of shortcomings, performance problems, as well as unfinished code analytics. 

If you would like to contribute to this project, please email me (aleksandrresetnikov093@gmail.com).

## ✅Additionally:
I started developing a java source code analyzer to determine which packages, classes, methods are in the library.

## ✅New:
1. JarDataLoader - loading data about jar file from xml file.
2. IJarDataSerialization - Interface for jar data serialization (implements: BinJarDataSerialization and XmlJarDataSerialization).
3. JarDataInstance - Information about an instance of the JarFile class for its further saving as a file.
4. AccessLevelManager - Quick actions with item access level.

## ✅Corrected:
1. Resource definition among jar content.
2. Regex-related slow loading of data.
3. Slowdown when determining the element type.
4. Confuses AccessLevel.Synchronized and AccessLevel.PublicClass
5. Distinguishes between types: synchronized*, deprecated params*, native params*.
