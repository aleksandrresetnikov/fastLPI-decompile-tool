namespace fastLPI.tools.decompiler.diagnostics
{
    public class DumpEventArgs
    {
        public string Path
        { get; private protected set; }

        public string Text
        { get; private protected set; }

        public bool DrawDate
        { get; private protected set; }

        public DumpEventArgs(string Path)
        {
            this.Text = Text;
        }

        public DumpEventArgs(string Path, string Text)
        {
            this.Path = Path;
            this.Text = Text;
        }

        public DumpEventArgs(string Path, string Text, bool DrawDate)
        {
            this.Path = Path;
            this.Text = Text;
            this.DrawDate = DrawDate;
        }
    }
}
