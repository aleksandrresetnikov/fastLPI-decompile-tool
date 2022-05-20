using System;
using System.Collections.Generic;
using System.IO;

namespace fastLPI.tools.decompiler.analytics
{
    public class JavaCodeMarkup
    {
        public string ProjectFolderPath { get; private set; }
        public Queue<DocumentItem> DocumentItems { get; private set; }

        private bool Loaded = false;

        public JavaCodeMarkup(string ProjectFolderPath)
        {
            this.ProjectFolderPath = ProjectFolderPath;
            this.DocumentItems = new Queue<DocumentItem>();
        }

        public void Load()
        {
            Busting(this.ProjectFolderPath);
            this.Loaded = true;
        }

        public void PrintDocuments()
        {
            if (!Loaded) throw new Exception();
            //int i = 1;
            foreach (DocumentItem item in this.DocumentItems)
                Console.WriteLine($"Package={item.Package} Type={item.DocumentType} Accesslevel={item.Accesslevel} Name={item.Name}");
            //Console.WriteLine($"#{i++}-{item.Path}, Package={item.Package}");
        }

        int i = 1;
        private void Busting(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);

            foreach (DirectoryInfo item in directoryInfo.GetDirectories())
                Busting(item.FullName);

            foreach (FileInfo item in directoryInfo.GetFiles())
                if (item.Extension == ".java")
                {
                    Console.WriteLine($"#{i++} - {item.FullName}");
                    this.DocumentItems.Enqueue(new DocumentItem(item.FullName));
                }
        }
    }
}
