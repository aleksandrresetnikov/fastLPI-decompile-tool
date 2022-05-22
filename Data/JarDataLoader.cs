using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.data
{
    public class JarDataLoader : IJarDataLoader, IDisposable
    {
        public static readonly string JavaExecutorProgram = "java";

        public int JarDataLoaderProcess_ExitCode 
        { get; private protected set; }

        public string JarDataLoaderProcess_ExitXmlResult
        { get; private protected set; }

        public virtual JarFile Document
        { get; private protected set; }

        public string JarPath = @"C:\Users\user\source\repos\Test\bin\Debug\netcoreapp3.1\data analytics\JarData\jd-gui-forLPI.jar";
        public string FilePath = @"C:\Users\user\source\repos\Test\bin\Debug\netcoreapp3.1\data analytics\JarData\jd-gui-forLPI.jar";
        public bool JarDataLoaderProcess_CreateNoWindow = true;

        private Process JarDataLoaderProcess;
        private Queue<DataReceivedEventArgs> JarDataLoaderProcess_OutputData = new Queue<DataReceivedEventArgs>();
        private Queue<DataReceivedEventArgs> JarDataLoaderProcess_ErrorData = new Queue<DataReceivedEventArgs>();

        public JarDataLoader(string FilePath)
        {
            this.FilePath = FilePath;
            this.JarPath = $@"{Util.GetLokationFolder()}\data analytics\JarData\jd-gui-forLPI.jar";

            this.InitJarDataLoaderProcess();
            this.InitJarDataLoaderProcessSetting();
        }

        public JarDataLoader(string FilePath, string JarPath)
        {
            this.FilePath = FilePath;
            this.JarPath = JarPath;

            this.InitJarDataLoaderProcess();
            this.InitJarDataLoaderProcessSetting();
        }

        private protected void InitJarDataLoaderProcess()
        {
            this.JarDataLoaderProcess = new Process();
            this.JarDataLoaderProcess.OutputDataReceived += this.JarDataLoaderProcess_OutputDataReceived;
            this.JarDataLoaderProcess.ErrorDataReceived += this.JarDataLoaderProcess_ErrorDataReceived;
            this.JarDataLoaderProcess.StartInfo.UseShellExecute = false;
            this.JarDataLoaderProcess.StartInfo.RedirectStandardOutput = true;
        }
        private protected void InitJarDataLoaderProcessSetting()
        {
            this.JarDataLoaderProcess.StartInfo.FileName = JavaExecutorProgram;
            this.JarDataLoaderProcess.StartInfo.Arguments = $"-jar \"{this.JarPath}\" \"{this.FilePath}\"";
            this.JarDataLoaderProcess.StartInfo.CreateNoWindow = this.JarDataLoaderProcess_CreateNoWindow;
        }

        private protected virtual void JarDataLoaderProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.JarDataLoaderProcess_OutputData.Enqueue(e);
        }
        private protected virtual void JarDataLoaderProcess_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            this.JarDataLoaderProcess_ErrorData.Enqueue(e);
        }

        public void Load()
        {
            this.JarDataLoaderProcess.Start();
            this.JarDataLoaderProcess.WaitForExit();
            this.JarDataLoaderProcess_ExitCode = this.JarDataLoaderProcess.ExitCode;
            this.JarDataLoaderProcess_ExitXmlResult = this.FilePath + "-data.xml";
        }

        private protected virtual void LoadJarDataContentFromXmlResult()
        {

        }

        public void SaveXmlResultTo(string path)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            try
            {
                GC.SuppressFinalize((object)this);
                GC.Collect();
            }
            catch (Exception ex) { }
        }
    }

    public class JarFile
    {
        public string XmlPath
        { get; private protected set; }

        public virtual JarDocumentLoadingProperties DocumentProperties
        { get; private protected set; }

        public Queue<JarDocumentItem> ChildItems
        { get; private protected set; }
    }

    public class JarDocumentLoadingProperties
    {
        /// <summary>
        /// .jar file data saving time.
        /// </summary>
        public long SaveTime
        { get; private protected set; }

        /// <summary>
        /// .jar file input path.
        /// </summary>
        public string InputPath
        { get; private protected set; }

        /// <summary>
        /// .jar file output path.
        /// </summary>
        public string OutputPath
        { get; private protected set; }
    }

    /// <summary>
    ///  Properties for the jar file (in the form of properties for the jar document).
    ///  Because data about the .jar file is loaded in the form of a document, this 
    ///concept will be referred to as "document".
    /// </summary>
    public class JarDocumentProperties
    {
        /// <summary>
        /// The name of the .jar document file.
        /// </summary>
        public string DocumentName
        { get; private protected set; }

        /// <summary>
        /// The size of the .jar document file.
        /// </summary>
        public int DocumentSize
        { get; private protected set; }

        /// <summary>
        /// The items length of the .jar document file.
        /// </summary>
        public int DocumentItemsLength
        { get; private protected set; }

        /// <summary>
        /// The items full length (all items) of the .jar document file.
        /// </summary>
        public int DocumentItemsFullLength
        { get; private protected set; }
    }

    public class JarDocumentItem
    {
        /// <summary>
        /// The path to the item.
        /// </summary>
        public string ItemLocationPath
        { get; private protected set; }

        /// <summary>
        /// Item name.
        /// </summary>
        public string ItemName
        { get; private protected set; }

        /// <summary>
        /// Item context.
        /// </summary>
        public string ItemContext
        { get; private protected set; }

        /// <summary>
        /// Item type.
        /// </summary>
        public JarDocumentItemType ItemType
        { get; private protected set; }
        /// <summary>
        /// The element's parent. Null if this is the root element.
        /// </summary>
        public JarDocumentItem ParentDocumentItem
        { get; private protected set; }

        /// <summary>
        /// Child elements.
        /// </summary>
        public Queue<JarDocumentItem> ChildItems
        { get; private protected set; }
    }

    /// <summary>
    /// Element types in .jar file.
    /// 
    /// Types:
    ///     1. None - Not defined (default value).
    ///     2. PackageItem - Package item or folder.
    ///     3. Class - java class.
    ///     4. Method - java method.
    ///     5. Field - java field or variable.
    ///     6. ClassFile - .class in the jar file.
    ///     7. Resource - java resource (images, text, json. xml, and more...).
    /// </summary>
    public enum JarDocumentItemType
    {
        /// <summary>
        /// None - Not defined (default value).
        /// </summary>
        None,

        /// <summary>
        /// Package item or folder.
        /// </summary>
        PackageItem,

        /// <summary>
        /// java class.
        /// </summary>
        Class,

        /// <summary>
        /// java method.
        /// </summary>
        Method,

        /// <summary>
        /// java field or variable.
        /// </summary>
        Field,

        /// <summary>
        /// .class in the jar file.
        /// </summary>
        ClassFile,

        /// <summary>
        /// java resource (images, text, json. xml, and more...).
        /// </summary>
        Resource
    }
}
