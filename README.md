# fastLPI-decompile-tool
A tool for C# that allows you to connect, configure and conveniently use any decompiler.

## Inspiration and needs.
I was making my own Java code editor in C#, I needed to know what packages, classes, methods are in Jar libraries (Jar files that the user imports) for further code hinting and syntax highlighting.

## Decision.
I found a very handy jd-cli (https://github.com/intoolswetrust/jd-cli) utility, which was a branch of the JD-Core project (https://github.com/java-decompiler/jd-core). It was decided to develop a C # Api, to which any decompiler could be connected. In this case, the input commands and parameters of the decompilers may differ, so you can specify your command dictionary, as well as add your own.

For example :
The jd-cli decompiler has an outputZipFile command that takes the value of the output zip path, and in the dictionary this command will be given as "-oz".

## Additionally.
I started developing a java source code analyzer to determine which packages, classes, methods are in the library.

## New:
1. JarDataLoader - loading data about jar file from xml file.
2. IJarDataSerialization - Interface for jar data serialization (implements: BinJarDataSerialization and XmlJarDataSerialization).
3. JarDataInstance - Information about an instance of the JarFile class for its further saving as a file.
