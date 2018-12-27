namespace CustomCode.Core.EditorConfig
{
    public sealed class QualificationForProperty
    {
        public void ShowCase()
        {
            // dotnet_style_qualification_for_property = true:error
            this.Foo = 42;

            // dotnet_style_qualification_for_property = false:error
            Foo = 42;
        }

        private int Foo { get; set; }
    }
}