using System;
using System.IO;

namespace fastLPI.tools.decompiler.analysis
{
    [Serializable]
    public class JavaSourseCode : IDisposable, ICloneable
    {
        private string _SourseCodePath;
        private string _SourseCodeText;

        public string SourseCodePath 
        {
            get => _SourseCodePath;
            set => this.SetSourseCodePath(value);
        }

        public string SourseCodeText 
        {
            get => _SourseCodeText;
            private protected set => _SourseCodeText = value;
        }

        public JavaSourseCode()
        { }

        public JavaSourseCode(string SourseCodePath)
        { this.SourseCodePath = SourseCodePath; }

        private protected virtual void SetSourseCodePath(string newSourseCodePath)
        {
            if (!File.Exists(newSourseCodePath)) throw new FileNotFoundException($"File \'{newSourseCodePath}\' not found.");
            this._SourseCodePath = newSourseCodePath;
            this.ReloadSourseCode();
        }

        private protected virtual void ReloadSourseCode()
        {
            using (FileStream fileStream = new FileStream(this._SourseCodePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    this.SourseCodeText = streamReader.ReadToEnd();
                }
            }

            GC.Collect();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect();
        }

        public object Clone()
        {
            return (object)new JavaSourseCode { SourseCodeText = this.SourseCodeText };
        }

        ~JavaSourseCode()
        {
            this.Dispose();
        }
    }
}
