namespace CustomCode.Core.EditorConfig
{
    public sealed class QualificationForField
    {
        public void ShowCase()
        {
            // dotnet_style_qualification_for_field = true:error
            this._foo = 42;

            // dotnet_style_qualification_for_field = false:error
            _foo = 42;
        }

        private int _foo;
    }
}