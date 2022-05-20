namespace fastLPI.tools.decompiler.analytics
{
    public class Method
    {
        public string Context { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string FullName { get; }
        public string ArgumentContext { get; set; }
        public string[] Arguments { get; set; }
    }
}
