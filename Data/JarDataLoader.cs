using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

using fastLPI.tools.decompiler.helper;
using fastLPI.tools.decompiler.data.building;
using fastLPI.tools.decompiler.diagnostics;

namespace fastLPI.tools.decompiler.data
{
    public class JarDataLoader : IJarDataLoader, IDisposable
    {
        public static readonly string JavaExecutorProgram = "java";

        /// <summary>
        /// The exit code of the .jar file data loading process.
        /// </summary>
        public int JarDataLoaderProcess_ExitCode 
        { get; private protected set; }

        /// <summary>
        /// Path to the output .xml file.
        /// </summary>
        public string JarDataLoaderProcess_ExitXmlResultPath
        { get; private protected set; }

        /// <summary>
        /// Xml document .jar file.
        /// </summary>
        public virtual JarFile Document
        { get; private protected set; }

        /// <summary>
        /// Xml file.
        /// </summary>
        public XElement XmlFile
        { get; private protected set; }

        public string JarPath = @"C:\Users\user\source\repos\Test\bin\Debug\netcoreapp3.1\data analytics\JarData\jd-gui-forLPI.jar";
        public string FilePath = @"C:\Users\user\source\repos\Test\bin\Debug\netcoreapp3.1\data analytics\JarData\jd-gui-forLPI.jar";
        public bool JarDataLoaderProcess_CreateNoWindow = true;

        private protected Process JarDataLoaderProcess;
        private protected Queue<DataReceivedEventArgs> JarDataLoaderProcess_OutputData = new Queue<DataReceivedEventArgs>();
        private protected Queue<DataReceivedEventArgs> JarDataLoaderProcess_ErrorData = new Queue<DataReceivedEventArgs>();

        private protected JarFileItemsBuilder ItemsBuilder;
        private protected JarDocumentLoadingPropertiesBuilder LoadingPropertiesBuilder;
        private protected JarDocumentPropertiesBuilder PropertiesBuilder;

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

        public JarDataLoader(string FilePath, string JarPath, bool JarDataLoaderProcess_CreateNoWindow)
        {
            this.FilePath = FilePath;
            this.JarPath = JarPath;
            this.JarDataLoaderProcess_CreateNoWindow = JarDataLoaderProcess_CreateNoWindow;

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
            try
            {
                this.JarDataLoaderProcess.Start();
                this.JarDataLoaderProcess.WaitForExit();
                this.JarDataLoaderProcess_ExitCode = this.JarDataLoaderProcess.ExitCode;
                this.JarDataLoaderProcess_ExitXmlResultPath = this.FilePath + "-data.xml";
                this.XmlFile = XElement.Load(this.JarDataLoaderProcess_ExitXmlResultPath);
            }
            catch (Exception ex)
            {
                Dump.AddDump("JarDocumentAccessLevelBuilder",
                    "\n\n\tJarDocumentAccessLevelBuilder\\BuildAccessLevel" +
                    "\nXmlItem::Value = " + this.XmlFile.Value +
                    "\nXmlItem::BaseUri = " + this.XmlFile.BaseUri +
                    "\nJarDataLoaderProcess_ExitXmlResultPath = " + this.JarDataLoaderProcess_ExitXmlResultPath +
                    "\n\tStackTrace: \n" + ex.StackTrace, true);
            }
        }

        public virtual void LoadJarDataContentFromXmlResult()
        {
            this.LoadingPropertiesBuilder = new JarDocumentLoadingPropertiesBuilder
                (this.XmlFile);

            this.ItemsBuilder = new JarFileItemsBuilder
                (this.XmlFile);

            this.PropertiesBuilder = new JarDocumentPropertiesBuilder
                (this.XmlFile, this.LoadingPropertiesBuilder.Build());

            BuildDocument();
        }
        private protected virtual void BuildDocument()
        {
            JarDocumentLoadingProperties DocumentLoadingProperties = this.LoadingPropertiesBuilder.Build();
            this.Document = new JarFile(this.JarDataLoaderProcess_ExitXmlResultPath,
                DocumentLoadingProperties, this.ItemsBuilder.BuildChildItems(),
                this.PropertiesBuilder.BuildDocumentProperties());
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(this.Document.DocumentLoadingProperties.JarFileName);
            Console.WriteLine(this.Document.DocumentLoadingProperties.InputPath);
            Console.WriteLine(this.Document.DocumentLoadingProperties.OutputPath);
            Console.WriteLine(this.Document.DocumentLoadingProperties.SaveTime);
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
}
