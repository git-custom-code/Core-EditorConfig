namespace CustomCode.Core.EditorConfig
{
    public sealed class ReadOnlyField
    {
        // dotnet_style_readonly_field = true
        private readonly string _foo = "constant";

        // dotnet_style_readonly_field = false
        private string _bar = "constant";
    }
}