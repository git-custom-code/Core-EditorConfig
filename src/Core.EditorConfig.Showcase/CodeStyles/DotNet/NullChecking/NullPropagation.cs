namespace CustomCode.Core.EditorConfig
{
    public sealed class NullPropagation
    {
        public void ShowCase()
        {
            object foo = null;

            // dotnet_style_null_propagation = true:error
            var @string = foo?.ToString();

            // dotnet_style_null_propagation = false:error
            @string = foo == null ? null : foo.ToString();
        }
    }
}