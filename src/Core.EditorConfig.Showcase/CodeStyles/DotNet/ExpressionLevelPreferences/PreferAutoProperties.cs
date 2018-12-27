namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferAutoProperties
    {
        // dotnet_style_prefer_auto_properties = true
        public int Foo { get; }

        // dotnet_style_prefer_auto_properties = false
        public int Bar
        {
            get { return _bar; }
        }

        private readonly int _bar;
    }
}