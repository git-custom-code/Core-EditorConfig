namespace CustomCode.Core.EditorConfig
{
    public sealed class QualificationForMethod
    {
        public void ShowCase()
        {
            // dotnet_style_qualification_for_method = true:error
            this.Foo();

            // dotnet_style_qualification_for_method = false:error
            Foo();
        }

        private void Foo()
        { }
    }
}