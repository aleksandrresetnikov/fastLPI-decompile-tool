namespace fastLPI.tools.decompiler.analysis
{
    public class DesignatedElement
    {
        public System.Text.RegularExpressions.Match match_data;
        public string context;

        public DesignatedElement(System.Text.RegularExpressions.Match match_data, string context)
        {
            this.match_data = match_data;
            this.context = context;
        }

        public override string ToString()
        {
            return this.context;
        }
    }
}
