using System.IO;
using System.Text.RegularExpressions;

using fastLPI.tools.decompiler.helper;

namespace fastLPI.tools.decompiler.analytics
{
    public class DocumentItem
    {
        public string Package { get; private protected set; }
        public string Path { get; private protected set; }
        public virtual string DocumentText { get; private protected set; }
        public virtual string[] DocumentLines { get; private protected set; }
        public virtual JavaClassType DocumentType { get; private protected set; }
        public virtual Accesslevel Accesslevel { get; private protected set; }
        public string Name { get; private protected set; }
        public virtual string FullName { get => $"{this.Package}.{this.Name}".RemoveSpaces(); }
        public virtual string ClassContent { get; private protected set; }
        public virtual Method[] Methods { get; private protected set; }

        public DocumentItem(string Path)
        {
            this.Path = Path;
            this.Load();
        }

        private protected virtual void Load()
        {
            this.DocumentText = File.ReadAllText(this.Path);
            this.DocumentLines = File.ReadAllLines(this.Path);

            LoadPackage();
            LoadClassType();
            LoadMethods();
        }

        private protected virtual void LoadPackage()
        {
            if (Regex.IsMatch(this.DocumentText, Patterns.JavaPackagePattern))
            {
                this.Package = Regex.Match(this.DocumentText, Patterns.JavaPackagePattern).Value.RemoveSpaces();
                this.Package = RemoveLinePackageText(this.Package);
                return;
            }

            /*foreach (string item in DocumentLines)
            {
                if (Regex.IsMatch(item, @"package(\s+?|\w+?|\.)*;"))
                {
                    this.Package = Regex.Match(item, @"package(\s+?|\w+?|\.)*;").Value.Replace(" ", "");
                    this.Package = RemoveLinePackageText(this.Package);
                    return;
                }
            }*/
        }

        private protected string RemoveLinePackageText(string text)
        {
            string outValue = text;
            outValue = outValue.RemoveSpaces();
            outValue = outValue.Replace(";", "");
            outValue = outValue.Remove(0, "package".Length);
            //for (int i = 0; i < "package".Length; i++)
            return outValue;
        }

        private protected virtual void LoadClassType()
        {
            if (Regex.IsMatch(this.DocumentText, Patterns.JavaClassPattern))
            {
                string counted = Regex.Match(this.DocumentText, Patterns.JavaClassPattern).Value;
                int index = Regex.Match(this.DocumentText, Patterns.JavaClassPattern).Index;

                this.ClassContent = ClassContentManager.GetClassContent(this.DocumentText, index);
                this.DocumentType = JavaClassType.Class;
                this.Accesslevel = Util.GetAccesslevel(Regex.Match(counted, Patterns.JavaAccesslevelsPattern).Value);
                //this.Name = Util.GetClassName(this.DocumentText);
                this.Name = Util.GetClassName(counted)/* + $"({counted})"*/;

                return;
            }
            else if (Regex.IsMatch(this.DocumentText, Patterns.JavaInterfacePattern))
            {
                string counted = Regex.Match(this.DocumentText, Patterns.JavaInterfacePattern).Value;
                int index = Regex.Match(this.DocumentText, Patterns.JavaInterfacePattern).Index;

                this.ClassContent = ClassContentManager.GetClassContent(this.DocumentText, index);
                this.DocumentType = JavaClassType.Interface;
                this.Accesslevel = Util.GetAccesslevel(Regex.Match(counted, Patterns.JavaAccesslevelsPattern).Value);
                //this.Name = Util.GetClassName(this.DocumentText);
                this.Name = Util.GetInterfaceName(counted)/* + $"({counted})"*/;

                return;
            }
            else if (Regex.IsMatch(this.DocumentText, Patterns.JavaEnumPattern))
            {
                string counted = Regex.Match(this.DocumentText, Patterns.JavaEnumPattern).Value;
                int index = Regex.Match(this.DocumentText, Patterns.JavaEnumPattern).Index;

                this.ClassContent = ClassContentManager.GetClassContent(this.DocumentText, index);
                this.DocumentType = JavaClassType.Enum;
                this.Accesslevel = Util.GetAccesslevel(Regex.Match(counted, Patterns.JavaAccesslevelsPattern).Value);
                //this.Name = Util.GetClassName(this.DocumentText);
                this.Name = Util.GetEnumName(counted)/* + $"({counted})"*/;

                return;
            }
            else
            {
                this.ClassContent = "#None";
                this.DocumentType = JavaClassType.None;
                this.Accesslevel = Accesslevel.None;
                this.Name = "#None";

                return;
            }

            /*foreach (string item in DocumentLines)
            {
                if (Regex.IsMatch(item, @"(private|public|public final|public abstract|\b)(\s+?)*class(\s+?)*(\w+?)*"))
                {
                    this.DocumentType = JavaClassType.Class;
                    this.Accesslevel = GetAccesslevel(Regex.Match(item, @"(private|public)").Value);
                    this.Name = GetClassName(item);
                    return;
                }
            }*/
        }

        private protected virtual void LoadMethods()
        {
            MethodUtil.GetMethodsInClass(this.ClassContent);
        }
    }
}
